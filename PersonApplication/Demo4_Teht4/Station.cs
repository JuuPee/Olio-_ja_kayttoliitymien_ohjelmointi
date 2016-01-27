using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht4
{
    class Station : Power
    {
        public float Frequency
        {
          get { return frequency; }
          set { if (value < 2000.0 && value < 26000.0) value = frequency; else Console.WriteLine("Give me another frequensy"); }
        }

        public Station(int power, float frequency)
            : base(power)
        {
            Frequency = frequency;
        }
        public override void Working()
        {
            Console.WriteLine("Your station is nice. ");
        }

        private float frequency;
    }
}
