using StatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Abstract
{
    public abstract class State
    {
        protected bool isConnected = true;
        public virtual void SimulateConnectionLoss() => isConnected = false;
        public abstract void Handle(Context context);
    }
}
