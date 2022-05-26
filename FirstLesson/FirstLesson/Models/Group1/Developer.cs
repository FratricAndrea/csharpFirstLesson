using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public class Developer : Employee
    {
        public override string Name { get; set; }
        //kreirati nepodrazumevani kostruktor
        public Developer(string deparment)
        {
            this.Department = deparment;
        }

        public override int CalculateNumberOfVacation()
        {
            return 20;
        }

        //zabraniti override metode u klasi koja ce naslediti Developer klasu
        public sealed override int CalculateSalary()
        {
            return 20000;
        }
    }
}
