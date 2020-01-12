using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Abstract
{
    public abstract class Participant<T>
    {
        protected string Name;

        public Participant(string name)
        {
            this.Name = name;
        }

        public abstract void SendMessage(Mediator<T> m, T message);

        public abstract void ReceiveMessage(T message);
    }
}
