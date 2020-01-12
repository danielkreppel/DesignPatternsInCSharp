using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Abstract
{
    public abstract class Mediator<T>
    {
        protected List<Participant<T>> Participants = new List<Participant<T>>();

        public abstract void Register(Participant<T> p);

        public abstract void SendMessage(Participant<T> sender, T message);
    }
}
