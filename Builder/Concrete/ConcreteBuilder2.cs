using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Concrete
{
    public class ConcreteBuilder2 : IBuilder
    {
        private Product _product = new Product();
        public void BuildParts()
        {
            _product.AddComponents(new List<IComponent> { new ConcreteComponent1("A"), new ConcreteComponent1("B"), new ConcreteComponent2("C") });
        }

        public Product GetProduct() => _product;
    }
}
