using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.Clubs
{
    public interface IMatchType
    {
        string Id { get; set; }
        string name { get; set; }
        string opponent { get; set; }
        int start_time { get; set; }
        string result { get; set;}
    }
}
