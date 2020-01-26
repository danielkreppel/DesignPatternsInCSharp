using ObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Concrete
{
    public class ConcreteObserver : Observer
    {
        private string Name;

        public ConcreteObserver(string name)
        {
            this.Name = name;
        }

        public override void Update(string state) =>
            Console.WriteLine($"Observer {Name} notified. New subject state: {state}");
    }
}
