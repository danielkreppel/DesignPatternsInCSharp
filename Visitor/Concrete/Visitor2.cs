using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Abstract;

namespace VisitorPattern.Concrete
{
    public class Visitor2 : AbstractVisitor
    {
        public override void VisitElement<T>(T element)
        {
            Console.WriteLine($"{element.GetType().Name} visited by {this.GetType().Name} with override behaviour");
        }
    }
}
