using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.Clubs
{
    class NoClubFoundException : Exception
    {
        public NoClubFoundException(string message) : base(message)
        {
            
        }
    }
}
