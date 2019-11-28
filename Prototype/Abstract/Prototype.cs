using PrototypeDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.Abstract
{
    public abstract class Prototype : ICloneable
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }

        //When the prototype has reference types in it, 
        //you need to be carefull about the cloning procedure using Shallow copy or Deep copy
        public PrototypeDetails PrototypeDetails { get; set; }

        public abstract object Clone();

        public override string ToString() => $"Property1:{Property1} Property2:{Property2} PrototypeDetails:{PrototypeDetails}";
    }
}
