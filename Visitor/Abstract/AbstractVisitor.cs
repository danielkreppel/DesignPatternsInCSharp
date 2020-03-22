using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Abstract
{
    public abstract class AbstractVisitor
    {
        public virtual void VisitElement<T>(T element) where T : Element
        {
            Console.WriteLine($"{element.GetType().Name} visited by {this.GetType().Name}");
        }

    }
}
