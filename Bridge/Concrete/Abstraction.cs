using Bridge.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    public class Abstraction
    {
        public IImplementor Implementor { get; set; }

        public virtual void Operation() => Implementor.Method();
    }
}
