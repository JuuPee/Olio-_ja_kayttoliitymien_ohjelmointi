using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    abstract class Human : IManmal
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        /*
        override public void Move(int amount)
         
        {
            Console.WriteLine("Human is moving " + amount + " steps.");
        }
        */
        public void GetOlder()
        {
            Age++;
            Console.WriteLine("Human is " + Age + " years old.");
        }
    }
}

