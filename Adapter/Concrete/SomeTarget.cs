using AdapterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    public class SomeTarget : ITarget
    {
        public void Request()
        {
            Console.WriteLine("Request from SomeTarget");
        }
    }
}
