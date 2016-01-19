using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;

            Console.Write("Anna luku > ");
            points = int.Parse(Console.ReadLine());
           
            switch (points)
            {
                case 0:
                case 1:
                    Console.Write("Sait arvosanan 0.");
                    break;
                case 2:
                case 3:
                    Console.Write("Sait arvosanan 1.");
                    break;
                case 4:
                case 5:
                    Console.Write("Sait arvosanan 2.");
                    break;
                case 6:
                case 7:
                    Console.Write("Sait arvosanan 3.");
                    break;
                case 8:
                case 9:
                    Console.Write("Sait arvosanan 4.");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.Write("Sait arvosanan 5.");
                    break;
                
            }
                
            }
                
        }
    }

