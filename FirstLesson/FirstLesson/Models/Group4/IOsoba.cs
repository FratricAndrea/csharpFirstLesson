using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group4
{
    public interface IOsoba
    {
        public void PrintName();

        //sealed ne moze da se koristi u interfejsu jer znaci da metoda nikada nece imati implementaciju
        //a to je poenta interfejsa
        //public sealed void PrintName();
    }
}
