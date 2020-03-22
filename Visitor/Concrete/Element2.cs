using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Abstract;

namespace VisitorPattern.Concrete
{
    public class Element2 : Element
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitElement(this);
        }

        public void OperationB() { }
    }
}
