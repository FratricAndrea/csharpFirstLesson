using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public class Car : Vehicle
    {
        //kako se ponasa koretna klasa kada u abstraktnoj klasi koju nasledjuje imamo
        //dva nepodrazumevana konstruktora ---> constructor overloading

        //public Car() : base("Tojota") { }
        public Car() : base("Tojota", Fuel.Benzin) { }
        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
