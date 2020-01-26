using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Abstract
{
    public abstract class Observer
    {
        public abstract void Update(string state);
    }
}
