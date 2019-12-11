using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Abstract
{

    public abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent comp)
        {
            component = comp;
        }

        public virtual void Operation() => component?.Operation();
    }
}
