﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Teht3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary
        {
            get { return salary; }
            set { if (value >= 0.0f) salary = value; else salary = 0.0f; }
        }

        public Employee(string name, string profession, float salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
        public virtual void Work()
        {
            Console.WriteLine("Working. Too much. Will die too young. Or get depressed. ");
        }

        private float salary;
    }
}
