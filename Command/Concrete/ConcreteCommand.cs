using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Abstract;

namespace CommandPattern.Concrete
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }

        public override void Execute() => Receiver.Action();
    }
}
