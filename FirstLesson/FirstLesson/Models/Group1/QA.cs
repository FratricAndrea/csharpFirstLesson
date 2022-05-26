using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public class QA: Employee
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int CalculateNumberOfVacation()
        {
            throw new NotImplementedException();
        }

        //u konkretnoj klasi napraviti implementaciju metode koja je deo abstraktne klase
        //public int CalculateSalary() {
        //    return 15000;
        //}

        //----> nije dozvoljeno jer se dobija greska jer postoje dve metode sa istim potpisom

        public override int CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
