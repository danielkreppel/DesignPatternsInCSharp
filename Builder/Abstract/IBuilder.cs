using Builder.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Abstract
{
    public interface IBuilder
    {
        void BuildParts();
        Product GetProduct();
    }
}
