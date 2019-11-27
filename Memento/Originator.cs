using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    //This is the generic structure that will wrap the most current object state with the option to restore an object state
    public class Originator<T> where T : ICloneable
    {
        private T StateObj { get; set; }

        public Memento<T> CreateMemento()
        {
            Memento<T> m = new Memento<T>();
            m.SetSate(this.StateObj);
            return m;
        }

        public void RestoreMemento(Memento<T> m)
        {
            this.StateObj = m.GetState();
        }

        public void SetState(T state)
        {
            this.StateObj = state;
        }

        public void ShowState()
        {
            Console.WriteLine(this.StateObj.ToString());
        }
    }
}
