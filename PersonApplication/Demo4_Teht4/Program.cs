using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Power on = new Power(1);
            Volume full = new Volume(1, 9);
            Station suomipop = new Station(1, 1);
        }
        static void Working(Power pwr)
        {
                pwr.Working();
        }
        
    }
}
