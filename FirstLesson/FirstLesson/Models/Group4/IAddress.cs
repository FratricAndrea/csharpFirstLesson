using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group4
{
    public interface IAddress
    {
        public string Name { get; set; }
        public void Print();
    }
}
