using API_Consumer.Cron;
using API_Consumer.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.Cron
{
    public class DoJob
    {
        public List<CronData> GetActiveJobs()
        {
            DateTime nowTime = DateTime.Now;

            List<CronData> cr = CSVManager.ReadCSVFromFile();

            var active = cr.Where(c => c.finished == false && c.hours > nowTime.Hour);

            return (List<CronData>)active;
        }
    }
}
