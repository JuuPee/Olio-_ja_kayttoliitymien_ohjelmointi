using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    abstract class IManmal
    {
        public int Age { get; set; }

        abstract public void Move(int amount);
            /*
        {
            Console.WriteLine("Manmal is moving " + amount + " steps.");
        }
        */
    }
}
