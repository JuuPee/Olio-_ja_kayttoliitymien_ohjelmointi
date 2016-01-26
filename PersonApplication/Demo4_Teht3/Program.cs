using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi", "Teacher", 4200.50f);
            Boss jussi = new Boss("Jussi", "Boss", 5000.0f, "Audi", 5000.0f);

            kirsi.Salary += 1000.0f;
            jussi.Salary -= 2000.0f;
            jussi.Bonus = 1000.0f;
            // kirsi.Bonus = nocando

            ShowSomeWork(kirsi);
            ShowSomeWork(jussi);

            Console.WriteLine();
        }
        static void ShowSomeWork(Employee empl)
        {
            empl.Work();
        }
    }
}
