using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht4
{
    class Power
    {
        public int On
        {
            get { return On; }
            set { if (value == 1) On = value; else On = 0; }
        }

        public Power(int power)
        {
            On = power;
        }
        public virtual void Working()
        {
            Console.WriteLine("Power is on. ");
        }

    }
}
