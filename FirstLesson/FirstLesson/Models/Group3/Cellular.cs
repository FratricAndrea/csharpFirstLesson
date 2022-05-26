using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group3
{
    public class Cellular : Phone
    {
        public override void Ring()
        {
            throw new NotImplementedException();
        }

        public override void RingVirtual()
        {
            Console.Write("virtual method - concrete class");
        }
    }
}
