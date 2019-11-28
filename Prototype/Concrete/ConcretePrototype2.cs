using PrototypeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.Concrete
{
    public class ConcretePrototype2 : Prototype
    {
        public string OtherProperty { get; set; }

        public override object Clone()
        {
            //return this.MemberwiseClone() <- Shallow copy
            //Making a Deep copy instead creating a new PrototypeDetails instance and including the OtherProperty
            return new ConcretePrototype2
            {
                Property1 = this.Property1,
                Property2 = this.Property2,
                PrototypeDetails = new PrototypeDetails { Details = this.PrototypeDetails.Details },
                OtherProperty = this.OtherProperty
            };
        }

        public override string ToString() => $"{base.ToString()} OtherProperty:{this.OtherProperty}";
    }
}
