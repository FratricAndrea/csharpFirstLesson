using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group3
{
    public class Satellite : Phone
    {
        public override void Ring()
        {
            base.RingVirtual();
            throw new NotImplementedException();
        }

        
    }
}
