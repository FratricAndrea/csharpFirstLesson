using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public abstract string Name { get; set; }
        public string Department { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime? EmploymentEndDate { get; set; }

        public abstract int CalculateSalary();
        public abstract int CalculateNumberOfVacation();
    }
}
