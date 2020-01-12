using MediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Concrete
{
    public class ConcreteParticipant<T> : Participant<T>
    {
        public ConcreteParticipant(string name) : base(name) { }

        public override void ReceiveMessage(T message) => Console.WriteLine($"{Name} received: {message}");

        public override void SendMessage(Mediator<T> m, T message) => m.SendMessage(this, message);
    }
}
