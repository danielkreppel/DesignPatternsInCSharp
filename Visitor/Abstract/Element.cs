using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Abstract;

namespace VisitorPattern.Abstract
{
    public abstract class Element
    {
        public abstract void Accept(AbstractVisitor visitor);
    }
}
