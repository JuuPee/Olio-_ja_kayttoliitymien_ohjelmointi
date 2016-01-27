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

            mycar.RemoveTyres();

            Console.WriteLine(mycar.ToString());

            Console.WriteLine();

            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "255/458/17"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "255/458/17"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "255/458/17"));

            Console.WriteLine(mycar.ToString());
            
            Console.WriteLine();
        }
    }
}
