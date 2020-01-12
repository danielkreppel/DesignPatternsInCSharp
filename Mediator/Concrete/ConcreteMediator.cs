using MediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Concrete
{
    public class ConcreteMediator<T> : Mediator<T>
    {
        public override void Register(Participant<T> p) => this.Participants.Add(p);

        public override void SendMessage(Participant<T> sender, T message) =>
            this.Participants.ForEach(p => { if (p != sender) p.ReceiveMessage(message); });

    }
}
