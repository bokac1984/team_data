using API_Consumer.Common;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace API_Consumer.ClubMatch.Registrations
{
    public class RegistrationManager
    {
        private readonly Registrations _RegistrationData;

        private readonly Commons commFunc;

        public HeaderData hData { get; set; }

        private readonly string MatchId;

        private readonly string ExcelLocation;

        public List<dynamic> MatchData { get; set; }

        public RegistrationManager(Registrations registrations, Commons cm, string matchId)
        {
            _RegistrationData = registrations;
            commFunc = cm;
            MatchId = matchId;

            hData = new HeaderData();

            ExcelLocation = Properties.Settings.Default.Excel_location;
        }

        public void PrepareData()
        {
            PrepareHaderData();
            RetrieveRegMatchData();
        }

        public void PrepareHaderData()
        {
            try
            {
                hData.MatchId = MatchId;
                hData.Name = _RegistrationData.Name;
                hData.StartTime = commFunc.FromUnixTime(_RegistrationData.StartTime);
                hData.BoardCount = _RegistrationData.Boards.ToString();

                hData.Description = _RegistrationData.Description;

                hData.Team1Name = _RegistrationData.Teams.Team1.Name;
                hData.Team2Name = _RegistrationData.Teams.Team2.Name;

                hData.AutoStart = _RegistrationData.Settings.Autostart ? "Da" : "Ne";
                hData.Tempo = (int.Parse(_RegistrationData.Settings.TimeControl.Split('/')[1]) / 86400).ToString() + "d";
                hData.MinGames = _RegistrationData.Settings.MinRequiredGames.ToString();
                hData.MinPlayers = _RegistrationData.Settings.MinTeamPlayers.ToString();
                hData.MatchType = _RegistrationData.Settings.Rules.ToString() == "chess960" ? "960" : "Standard";
                hData.WL = hData.Name.Contains("WL");
                hData.EL = hData.Name.Contains("EL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška uhvaćena!" + ex.Message);
            }
        }
        /// <summary>
        /// Vrati podatke za grid a možda i potencijalno i za excel view
        /// </summary>
        /// <returns></returns>
        public void RetrieveRegMatchData()
        {
            var tabele = new List<dynamic>();

            var igraci2 = from b in _RegistrationData.Teams.Team2.Players
                              //from c in mec.Teams.Team2.Players
                          orderby b.Rating descending
                          select new Player()
                          {
                              Username = b.Username,
                              Rd = b.Rd,
                              Status = b.Status,
                              TimeoutPercent = b.TimeoutPercent,
                              Rating = b.Rating
                          };
            var igraci1 = from b in _RegistrationData.Teams.Team1.Players
                              //from c in mec.Teams.Team2.Players
                          orderby b.Rating descending
                          select new Player()
                          {
                              Username = b.Username,
                              Rd = b.Rd,
                              Status = b.Status,
                              TimeoutPercent = b.TimeoutPercent,
                              Rating = b.Rating
                          };

            if (igraci1.Count() >= igraci2.Count())
            {
                for (int i = 0; i < igraci1.Count(); i++)
                {
                    if (i >= igraci2.Count())
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,



                            t2_Rating = new long(),
                            t2_Rd = new double(),
                            t2_TimeoutPercent = new double(),
                            t2_Status = new Status(),
                            t2_Username = "",
                        });
                    }
                    else
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,
                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username
                        });
                    }
                }
            }
            else
            {
                for (int i = 0; i < igraci2.Count(); i++)
                {
                    if (i >= igraci1.Count())
                    {
                        tabele.Add(new
                        {
                            t1_Username = "",
                            t1_Status = new Status(),
                            t1_TimeoutPercent = new double(),
                            t1_Rd = new double(),
                            t1_Rating = new long(),


                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username


                        });
                    }
                    else
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,
                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username
                        });
                    }
                }
            }

            MatchData = tabele;
        }

        public string ExportToExcel()
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    //create a new Worksheet
                    ExcelWorksheet ws = excelPackage.Workbook.Worksheets.Add("Sheet 1");
                    string matchLeague = "";

                    if (hData.WL && !hData.EL)
                    {
                        matchLeague = "_WL";
                    } else if (!hData.WL && hData.EL)
                    {
                        matchLeague = "_EL";
                    }

                    matchLeague = matchLeague + "_" + MatchId;

                    string nazivFajla = hData.Team1Name.Replace(" ", "_") + "_vs_" + hData.Team2Name.Replace(" ", "_") + matchLeague + "_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".xlsx";
                    string filePath = ExcelLocation + nazivFajla;

                    if (File.Exists(filePath))
                    {
                        return "Već postoji fajl!";
                    }

                    ws.Cells["A1"].Value = "MatchID";
                    ws.Cells["A2"].Value = "StartTime";
                    ws.Cells["A3"].Value = "BoardCount";
                    ws.Cells["A4"].Value = "Description";
                    ws.Cells["A5"].Value = "AutoStart";
                    ws.Cells["A6"].Value = "Tempo";
                    ws.Cells["A7"].Value = "MinGames";
                    ws.Cells["A8"].Value = "MinPlayers";
                    ws.Cells["A9"].Value = "Tip";
                    ws.Cells["A11"].Value = "Team 1";
                    ws.Cells["A12"].Value = "Team 2";

                    //ExcelRange rng1 = ws.Cells["A1", "A12"];
                    //rng1.Font.Bold = true;

                    ws.Cells["B1"].Value = hData.MatchId;
                    ws.Cells["B2"].Value = hData.StartTime;
                    ws.Cells["B3"].Value = hData.BoardCount;
                    ws.Cells["B4"].Value = hData.Description;
                    ws.Cells["B5"].Value = hData.AutoStart;
                    ws.Cells["B6"].Value = hData.Tempo;
                    ws.Cells["B7"].Value = hData.MinGames;
                    ws.Cells["B8"].Value = hData.MinPlayers;
                    ws.Cells["B9"].Value = hData.MatchType;
                    ws.Cells["B11"].Value = hData.Team1Name;
                    ws.Cells["B12"].Value = hData.Team2Name;

                    //Excel.Range rng = (Excel.Range)sh.Range[sh.Cells["14", "A"], sh.Cells["14", "J"]];
                    //rng.EntireRow.Font.Bold = true;

                    int i = 15;

                    ws.Cells["A14"].Value = hData.Team1Name;
                    //ws.Cells["B14", "B"].Value2 = "Status";
                    ws.Cells["B14"].Value = "TO %";
                    ws.Cells["C14"].Value = "RD";
                    ws.Cells["D14"].Value = "Rejting";
                    ws.Cells["E14"].Value = "Rejting";
                    ws.Cells["F14"].Value = "RD";
                    ws.Cells["G14"].Value = "TO %";
                    //ws.Cells["14", "I"].Value2 = "Status";
                    ws.Cells["H14"].Value = hData.Team2Name;


                    foreach (dynamic item in MatchData)
                    {
                        ws.Cells["A" + i.ToString()].Value = item.t1_Username;
                        //sh.Cells[i.ToString(), "B"].Value2 = item.t1_Status;
                        ws.Cells["B"+i.ToString()].Value = item.t1_TimeoutPercent;
                        ws.Cells["C"+i.ToString()].Value = item.t1_Rd;
                        ws.Cells["D"+i.ToString()].Value = item.t1_Rating;
                        ws.Cells["E"+i.ToString()].Value = item.t2_Rating;
                        ws.Cells["F"+i.ToString()].Value = item.t2_Rd;
                        ws.Cells["G"+i.ToString()].Value = item.t2_TimeoutPercent;
                        //sh.Cells[i.ToString(), "I"].Value2 = item.t2_Status;
                        ws.Cells["H"+ i.ToString()].Value = item.t2_Username;
                        i++;
                    }

                    //convert the excel package to a byte array
                    byte[] bin = excelPackage.GetAsByteArray();

                    //write the file to the disk
                    File.WriteAllBytes(filePath, bin);

                    return "Sačuvano: " + nazivFajla;
                }
            }
            catch (Exception ex)
            {
                return "Greška uhvaćena!" + ex.Message;
            }
        }
    }
}
