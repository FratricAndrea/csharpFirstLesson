using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLesson.Models.Group4
{
    public class Company : IAddress, IEmployed
    {
        //public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void Print()
        //{
        //    Console.WriteLine("Company");
        //}
        string IAddress.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployed.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IAddress.Print()
        {
            Console.WriteLine("Company - IAddress");
        }

        void IEmployed.Print()
        {
            Console.WriteLine("Company - IEmployed");
        }
    }
}
