using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    public class ClassA : AbstractClass
    {
        protected override void Operation2()
        {
            Console.WriteLine("Operation 2 defined by ClassA");
        }
        protected override void Operation4()
        {
            Console.WriteLine("Operation 4 defined by ClassA");
        }
    }
}
