using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group4
{
    public class Person : IOsoba, IZaposleni
    {
        public void PrintName()
        {
            Console.WriteLine("Andrea");
        }
    }
}
