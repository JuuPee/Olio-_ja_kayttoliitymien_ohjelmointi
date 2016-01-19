using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, kulutus, kustannus;

            Console.WriteLine("Anna ajettava matka ");
            matka = int.Parse(Console.ReadLine());

            kulutus = ((matka / 100) * 7.02);
            kustannus = (kulutus * 1.595);

            Console.WriteLine("Ajettavaan matkaan kuluu bensaa " + kulutus + " bensaa ");
            Console.WriteLine("Ja kustannukset ovat " + kustannus + ".");
        }
    }
}
