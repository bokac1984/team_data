using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace API_Consumer.CSV
{
    public class CSVManager
    {
        public static List<CronData> ReadCSVFromFile()
        {
            List<CronData> cr = new List<CronData>();
            string lokacija = Properties.Settings.Default.Cron_Location + "cron.csv";

            if (!File.Exists(lokacija))
            {
                return cr;
            }

            using (var reader = new StreamReader(lokacija))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    cr.Add(new CronData()
                    {
                        hours = int.Parse(values[0]),
                        minutes = int.Parse(values[1]),
                        matchID = int.Parse(values[2]),
                        registration = int.Parse(values[3]),
                        finished = int.Parse(values[4]) > 0,
                    });
                }
            }

            return cr;
        }

        public static List<CronData> GetActiveJobs()
        {
            DateTime nowTime = DateTime.Now;

            List<CronData> cr = CSVManager.ReadCSVFromFile();

            var active = cr.Where(c => c.finished == false && c.hours >= nowTime.Hour && c.minutes >= nowTime.Minute).ToList<CronData>();

            return active;
        }

        public static void StoreCSVToFile(string line)
        {
            string lokacija = Properties.Settings.Default.Cron_Location + "cron.csv";

            if (!File.Exists(lokacija))
            {
                File.Create(lokacija);
            }

            using (StreamWriter writer = new StreamWriter(lokacija))
            {
                writer.WriteLine(line);
            }
        }

        public static void UpdateOrInsertCSV(string ID, bool insert = false)
        {
            try
            {
                string path = Properties.Settings.Default.Cron_Location + "cron.csv";
                List<String> lines = new List<String>();

                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        String line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (!insert && line.Contains(";"))
                            {
                                String[] split = line.Split(';');

                                if (split[2].Contains(ID))
                                {
                                    split[4] = "1";
                                    line = String.Join(";", split);
                                }
                            }

                            lines.Add(line);
                        }
                    }
                }

                if (insert)
                    lines.Add(ID);

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    foreach (String line in lines)
                        writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod snimanja automatike: " + ex.Message);
            }
        }
    }
}
