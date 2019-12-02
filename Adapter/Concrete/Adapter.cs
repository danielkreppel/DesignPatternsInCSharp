using AdapterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    //Adapting the incompatible class so it can be used as an ITarget
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            MethodFromAdaptee();
        }
    }
}
