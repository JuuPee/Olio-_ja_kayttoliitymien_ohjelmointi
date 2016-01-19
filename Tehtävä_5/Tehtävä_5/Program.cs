using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tunnit, minuutit, sekunnit;

            Console.WriteLine("Anna sekuntien määrä: ");
            sekunnit = int.Parse(Console.ReadLine());

            tunnit = sekunnit / 3600;
            sekunnit = sekunnit - tunnit * 3600;

            minuutit = sekunnit / 60;
            sekunnit = sekunnit - minuutit * 60;

            Console.WriteLine("Tuntien määrä: " + tunnit);
            Console.WriteLine("Minuuttien määrä: " + minuutit);
            Console.WriteLine("Sekuntien määrä: " + sekunnit);

        }
    }
}
