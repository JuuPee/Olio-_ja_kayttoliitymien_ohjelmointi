using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("12345-553", "Lauri", "Pouta", 29, 78, 185));
            persons.Add(new Person("12345-555555555553", "Pekka", "Pouta", 46, 78, 185));
            persons.Add(new Person("12345559595-553", "Pena", "Pouta", 39, 78, 185));
            persons.Add(new Person("12345-558883", "Jukka", "Pouta", 42, 78, 185));
            persons.Add(new Person("12345-58855553", "Pekka69", "Pouta", 33, 78, 185));
            persons.Add(new Person("12345-55888878783", "Mikko", "Pouta", 36, 78, 185));
            persons.Add(new Person("12345-557878783", "Tankki", "Pouta", 27, 178, 185));
            persons.Add(new Person("12345-512112153", "Petra", "Pouta", 22, 78, 185));
            persons.Add(new Person("12345-558488543", "Laura", "Pouta", 40, 78, 185));
            persons.Add(new Person("12345-57878753", "Niina", "Pouta", 37, 78, 185));

           /*foreach (Person somebody in persons) // personit normaalissa järjestyksessä
            {
                Console.Write(somebody.ToString());
            }
            */
            persons.Sort((x, y) => x.Age.CompareTo(y.Age)); // personit jarjestyksessä iän mukaan
            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }
            //try to find a person...
            string SSN = "12345-557878783";

            Person found = persons.Find(x => x.SSN == SSN);
            if (found != null)
            {
                Console.WriteLine("Persons with SSN " + SSN + " found.");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            for (int i=0; i < persons.Count; i++)
            {
                if (persons[i].Age == 40)
                {
                    persons.RemoveAt(i);
                    break;
                }
            }
            /*foreach (Person somebody in persons)
            {
                if (somebody.SSN == SSN)
                {
                    Console.WriteLine("Persons with SSN " + SSN + " found");
                    break;
                }
            }*/
            Console.ReadLine();
        }
    }
}
