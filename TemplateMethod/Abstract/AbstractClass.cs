using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Abstract
{
    public abstract class AbstractClass
    {
        protected void Operation1() => Console.WriteLine("Operation 1");

        protected abstract void Operation2();

        protected void Operation3() => Console.WriteLine("Operation 3");

        protected abstract void Operation4();

        public void TemplateMethod()
        {
            Operation1();
            Operation2(); //To be defined in the subclass
            Operation3();
            Operation4(); //To be defined in the subclass
        }
    }
}
