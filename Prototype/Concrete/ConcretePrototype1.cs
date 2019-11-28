using System;
using System.Collections.Generic;
using System.Text;
using PrototypeDesignPattern.Abstract;

namespace PrototypeDesignPattern.Concrete
{
    public class ConcretePrototype1 : Prototype
    {
        public override object Clone()
        {
            //return this.MemberwiseClone() <- Shallow copy
            //Making a Deep copy instead creating a new PrototypeDetails instance
            return new ConcretePrototype1
            {
                Property1 = this.Property1,
                Property2 = this.Property2,
                PrototypeDetails = new PrototypeDetails { Details = this.PrototypeDetails.Details }
            };
        }
    }
}
