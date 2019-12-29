using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Abstract
{
    public abstract class ChainHandler
    {
        protected string Name;
        public Func<int, bool> Condition;
        public ChainHandler Successor { get; set; }

        public ChainHandler(string name)
        {
            this.Name = name;
        }
        public abstract void HandleRequest(int value);
    }
}
