using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    public class ClassB : AbstractClass
    {
        protected override void Operation2()
        {
            Console.WriteLine("Operation 2 defined by ClassB");
        }
        protected override void Operation4()
        {
            Console.WriteLine("Operation 4 defined by ClassB");
        }
    }
}
