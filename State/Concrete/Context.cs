using StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Concrete
{
    public class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }

        public void Request()
        {
            State.Handle(this);
            Console.WriteLine($"Using communication object: {State.GetType().Name}");
        }
    }
}
