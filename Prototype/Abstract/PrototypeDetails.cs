using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.Abstract
{
    public class PrototypeDetails
    {
        public string Details { get; set; }

        public override string ToString() => this.Details;
    }
}
