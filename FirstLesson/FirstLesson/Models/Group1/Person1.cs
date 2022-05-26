using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public class Person1 : Developer
    {
        public Person1(): base("Office") { }

        //visestruki override
        public override int CalculateNumberOfVacation()
        {
            return 10;
        }

        //public override int CalculateNumberOfVacation2()
        //{
        //    return 10;
        //}

        //Pokusaj override metode iz gornje klase kod koje je zabranjen override
        //public override int CalculateSalary()
        //{
        //    return 5000;
        //}
    }
}
