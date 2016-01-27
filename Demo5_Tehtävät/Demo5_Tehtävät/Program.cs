using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Tehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Audi", "A7");

            Console.WriteLine(mycar.ToString());

            Console.WriteLine();

        }
    }
}
