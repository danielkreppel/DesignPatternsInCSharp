using DecoratorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Concrete
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent comp) : base(comp) { }
        public override void Operation()
        {
            base.Operation();
            AddedBehaviour();
            Console.WriteLine("Operation from ConcreteDecoratorA");
        }
        void AddedBehaviour() => Console.Write("(AddedBehaviour A) + ");
    }
}
