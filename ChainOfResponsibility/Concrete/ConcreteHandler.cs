using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Concrete
{
    public class ConcreteHandler : ChainHandler
    {
        public ConcreteHandler(string name) : base(name) { }
        public override void HandleRequest(int value)
        {
            if (Condition(value))
                Console.WriteLine($"{this.Name} handled the value {value}");
            else
                this.Successor.HandleRequest(value);
        }
    }
}
