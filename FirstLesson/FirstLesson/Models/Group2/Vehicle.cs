using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public Fuel Gorivo { get; set; }

        //dva nepodrazumevana konstruktora ---> constructor overloading
        public Vehicle(string name) {
            this.Name = name;
        }
        public Vehicle(string name, Fuel fuel)
        {
            this.Name = name;
            this.Gorivo = fuel;
        }

        public enum Fuel
        {
            Benzin,
            Dizel,
            Elektricni
        }
        public abstract void Run();
    }
}
