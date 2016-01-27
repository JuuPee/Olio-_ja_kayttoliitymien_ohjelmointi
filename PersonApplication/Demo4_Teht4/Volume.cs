using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht4
{
    class Volume : Power
    {
        public int Voice
        {
            get { return voice; }
            set { if (value < 1 && value < 9) value = voice; else Console.WriteLine("Give a new volume level (1-9)"); }
        }
        public Volume(int power, int voice)
            : base(power)
        {
            Voice = voice;
        }
        public override void Working()
        {
            Console.WriteLine("Volume is on. ");
        }

        private int voice;
    }
}
