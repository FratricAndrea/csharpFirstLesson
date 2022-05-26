using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group3
{
    public class LandLine : Phone
    {
        public override void Ring()
        {
            throw new NotImplementedException();
        }

        //ukoliko zelimo da obicna metoda ima mogucnost override-a oznaciti je sa virtual

        public virtual void Print() {
            Console.WriteLine("Print from Landline");
        }
     }
}
