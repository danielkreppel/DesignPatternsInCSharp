using DecoratorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Concrete
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent comp) : base(comp) { }
        public override void Operation()
        {
            base.Operation();
            AddedBehaviour();
            Console.WriteLine("Operation from ConcreteDecoratorB");
        }
        void AddedBehaviour() => Console.Write("(AddedBehaviour B) + ");
    }
}
