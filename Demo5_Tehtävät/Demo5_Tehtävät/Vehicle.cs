using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Tehtävät
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;

            tyres = new List<Tyre>();

            tyres.Add(new Tyre("Michelin", "X-ice", "255/458/17"));
            tyres.Add(new Tyre("Michelin", "X-ice", "255/458/17"));
            tyres.Add(new Tyre("Michelin", "X-ice", "255/458/17"));
            tyres.Add(new Tyre("Michelin", "X-ice", "255/458/17"));

        }
        public override string ToString()
        {
            string s = "Vehicle: " + Brand + ", " + Model;

            foreach (Tyre t in tyres)
            {
                s += "\n";
                s += ToString();
            
            }
            return s;
        }


        private List<Tyre> tyres;
    }
}
