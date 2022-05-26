using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group3
{
    public abstract class Phone
    {     
        public abstract void Ring();

        //Virtual - It tells the compiler that this method can be overridden by derived classes.
        //ne moze u isto vreme da bude virtual i abstract metoda
        public virtual void RingVirtual() {
            Console.Write("virtual method - base class");
        }
    }
}
