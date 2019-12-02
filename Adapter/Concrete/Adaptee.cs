using AdapterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    //The incompatible class
    public class Adaptee : ISomeOhterInterface
    {
        public void MethodFromAdaptee()
        {
            Console.WriteLine("Request from Adaptee");
        }
    }
}
