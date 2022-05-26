using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group3
{
    public class Satellite : Phone
    {
        public override void Ring()
        {
            //primer koricenja mmetode iz bazne klase sa base
            base.RingVirtual();
            throw new NotImplementedException();
        }

        
    }
}
