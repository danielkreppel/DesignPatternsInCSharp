using CommandPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Abstract
{
    public abstract class Command
    {
        protected Receiver Receiver;

        public Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public abstract void Execute();
    }
}
