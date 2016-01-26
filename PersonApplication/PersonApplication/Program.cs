using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "Joe";
            somebody.LastName = "Dirt";
            somebody.Address = "Unknown";
            somebody.Age = 25;
            somebody.PhoneNumber = "0500 123456789";
            Console.WriteLine(somebody.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Rape";
            teacher.LastName = "Ström";
            teacher.Address = "Unknown";
            teacher.Age = 69;
            teacher.PhoneNumber = "Unknown";
            Console.WriteLine(teacher.ToString());

            Student theStudent = new Student("Pekka", "Pouta", "666 999");
            theStudent.Address = "Kilju 3";
            theStudent.Age = 15;
            theStudent.PhoneNumber = "12345678555559";
            Console.WriteLine(theStudent.ToString());

            somebody.PersonMethod();
            teacher.PersonMethod();
            teacher.TeacherMethod();
            theStudent.PersonMethod();
            theStudent.StudentMethod();

            // no no no
            //teacher.StudentMethod();
            //theStudent.TeacherMethod();
             
        }
    }
}
