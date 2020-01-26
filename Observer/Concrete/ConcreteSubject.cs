using ObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Concrete
{
    public class ConcreteSubject : Subject
    {
        public ConcreteSubject(string state)
        {
            SetState(state);
        }

        public override void SetState(string state)
        {
            if (this.SubjectState != state)
            {
                this.SubjectState = state;
                Notify();
            }
        }
    }
}
