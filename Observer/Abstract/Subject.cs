using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Abstract
{
    public abstract class Subject
    {
        protected string SubjectState;

        protected List<Observer> Observers = new List<Observer>();

        public virtual void Attach(Observer o) => Observers.Add(o);

        public virtual void AttachRange(List<Observer> o) => Observers.AddRange(o);

        public virtual void Dettach(Observer o) => Observers.Remove(o);

        public abstract void SetState(string state);

        protected virtual void Notify() => Observers.ForEach(o => o.Update(this.SubjectState));
    }
}
