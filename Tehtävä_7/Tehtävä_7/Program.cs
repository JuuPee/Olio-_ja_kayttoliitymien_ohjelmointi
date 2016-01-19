using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosiluku;
            int jaollisuus1, jaollisuus2;

            Console.WriteLine("Anna vuosiluku: ");
            vuosiluku = int.Parse(Console.ReadLine());

            jaollisuus1 = vuosiluku % 4;
            jaollisuus2 = vuosiluku % 400; 

            if (jaollisuus2 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else if (jaollisuus1 == 0)
            {
                Console.WriteLine("hastag Vuosi on karkausvuosi.");
            }
            else if (jaollisuus1 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
        }
    }
}
