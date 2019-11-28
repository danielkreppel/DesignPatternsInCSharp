using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Concrete
{
    public class Director
    {
        public void Construct(IBuilder builder) => builder.BuildParts();
    }
}
