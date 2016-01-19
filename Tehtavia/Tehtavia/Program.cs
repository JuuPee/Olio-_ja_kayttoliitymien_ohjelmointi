using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavia
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit luvun " + luku);
        }
    }
}
