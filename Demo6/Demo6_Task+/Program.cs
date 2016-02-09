using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Task4
{
    class Program
    {
        static private Random rand;
        static string RandomString(int lenght)
        {
            string ret = "";
            for (int i =0; i < lenght; i++)
            {
                ret += (char)rand.Next('A', 'Z');
            }
            return ret;
        }
        static void Main(string[] args)
        {
            Random r = new Random();

            List<Person> Persons = new List<Person>();

            const int personCount = 10;
            for (int i=0; i< personCount; i++)
            {
                Person p = new Person();
            }
            r.Next();
        }
    }
}
