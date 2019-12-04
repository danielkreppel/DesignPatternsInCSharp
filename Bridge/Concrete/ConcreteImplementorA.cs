using Bridge.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    public class ConcreteImplementorA : IImplementor
    {
        public void Method() => Console.WriteLine("Method called from ConcreteImplementorA");
    }
}
