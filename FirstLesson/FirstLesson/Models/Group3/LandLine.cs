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

        public virtual void Print() {
            Console.WriteLine("Print from Landline");
        }
     }
}
