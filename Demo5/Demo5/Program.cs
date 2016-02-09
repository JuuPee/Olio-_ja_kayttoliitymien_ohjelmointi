using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby manmal = new Baby();
            manmal.Move(10);

            for (int i= 0; i<50; i++)
            {
                manmal.GetOlder();
            }

            Console.ReadLine();
        }
    }
}
