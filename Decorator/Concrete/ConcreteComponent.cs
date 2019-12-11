using DecoratorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Concrete
{
    public class ConcreteComponent : IComponent
    {
        public void Operation() => Console.WriteLine("Operation from ConcreteComponent");
    }
}
