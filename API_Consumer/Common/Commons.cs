using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_Consumer.Common
{
    public class Commons : ICommons
    {
        public void copyAlltoClipboard(DataGridView dgv)
        {
            dgv.SelectAll();
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

        public void saveToExcel(DataGridView dgv)
        {
            copyAlltoClipboard(dgv);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Range CR = (Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }


        public void showRightMenu(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (e.Button == MouseButtons.Right)
            {
                saveToExcel(grid);
            }
        }

        public string FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime).ToString("yyyy.MM.dd HH:mm:ss");
        }

        public DateTime FromUnixTimeDateTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
        /// <summary>
        /// 
        /// Daj novi datum po unixu
        /// 
        /// </summary>
        /// <returns></returns>
        public long UnixNow()
        {
            return (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        /*
            public const float win = 1;
            public const float checkmated = 1;
            public const float agreed = 0.5f;
            public const float repetition = 0.5f;
            public const float timeout = 0;
            public const float resigned = 0;
            public const float stalemate = 0.5f;
            public const float lose = 0;
         * */

        public float resultValue(string resultType)
        {
            float returnValue = 0;
            switch (resultType)
            {
                case "win": returnValue = 1; break;
                case "checkmated": returnValue = 0; break;
                case "agreed": returnValue = 0.5f; break;
                case "repetition": returnValue = 0.5f; break;
                case "timeout": returnValue = 0; break;
                case "resigned": returnValue = 0; break;
                case "stalemate": returnValue = 0.5f; break;
                case "insufficient": returnValue = 0.5f; break;
                case "abandoned": returnValue = 0; break;
                case "lose": returnValue = 0; break;
                default: returnValue = 0; break;
            }

            return returnValue;
        }

        public string getLastPart(string a)
        {
            Uri uri = new Uri(a);
            return uri.Segments.Last();
        }

        public T getDeserializedObject<T>(object json)
        {
            return JsonConvert.DeserializeObject<T>(json.ToString());
        }

        public string ParsePGN(string text)
        {
            return JsonConvert.DeserializeObject<string>(text).ToString();
        }
        /// <summary>
        /// Kreiraj klik na dugme za grid sa igračima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="playerOneColumn"></param>
        /// <param name="playerTwoColumn"></param>
        public void viewPlayer(object sender, int playerOneColumn, int playerTwoColumn)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                int ColIndex = dgv.CurrentCell.ColumnIndex;
                int RowIndex = dgv.CurrentCell.RowIndex;

                if (ColIndex != playerOneColumn && ColIndex != playerTwoColumn)
                {
                    throw new NotSupportedException("Morate kliknuti samo na ime igrača!");
                }

                string playerNameHere = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex].Value.ToString();
                Players.PlayerViewById forma = new Players.PlayerViewById
                {
                    _PlayerName = playerNameHere
                };

                forma.Show();
                forma.PretrazSaDrugeForme();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška, zovi Bokca, ovo je greška: " + ex.ToString());
            }
        }

        public void ResizeColumns(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public bool isLiveMatch(string matchUrl)
        {
            return matchUrl.Contains("live");
        }
    }
}
