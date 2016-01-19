using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            int summa, keskiarvo;

            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3;

            Console.WriteLine("Lukujen summa on " + summa);
            Console.WriteLine("Ja keskiarvo " + keskiarvo);


        }
    }
}
