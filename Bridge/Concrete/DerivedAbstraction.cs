using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    public class DerivedAbstraction : Abstraction
    {
        public override void Operation() => Implementor.Method();
    }
}
