using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    //This is the Memento generic structure to wrap the objects to keep state
    public class Memento<T> where T : ICloneable
    {
        private T StateObj { get; set; }

        public T GetState()
        {
            return StateObj;
        }

        public void SetSate(T stateObj)
        {
            StateObj = (T)stateObj.Clone();
        }
    }
}
