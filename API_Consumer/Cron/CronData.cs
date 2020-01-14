using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.CSV
{
    public partial class CronData
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int matchID { get; set; }
        public int registration { get; set; }
        public bool finished { get; set; }
    }
}
