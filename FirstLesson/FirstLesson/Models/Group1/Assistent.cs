using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    //zabraniti nasledjivanje klase
    public sealed class Assistent : Employee
    {
        public override string Name { get ; set ; }

        public override int CalculateNumberOfVacation()
        {
            throw new NotImplementedException();
        }

        public override int CalculateSalary()
        {
            return 10000;
        }
    }
}
