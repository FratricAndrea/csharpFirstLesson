using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Klase
{
    static class Bank
    {
        //u static klasi ne moze da definisemo clanove koji nisu static
        //public string Name { get; set; }
        //public string Address { get; set; }

        public static string Name { get; set; } = "Komercijalna";
        public static string Address { get; set; }

        //static klasa ne moze da ima nepodrazumevani konstruktor jer ne moze ni istanca da se napravi
        //public Bank() { }
    }

    public partial class Employee {

        public void DoWork()
        {
            Console.WriteLine("Do work");
        }
    }
}
