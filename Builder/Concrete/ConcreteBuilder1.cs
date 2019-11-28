using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Concrete
{
    public class ConcreteBuilder1 : IBuilder
    {
        private Product _product = new Product();
        public void BuildParts()
        {
            _product.AddComponents(new List<IComponent> { new ConcreteComponent1("Comp1"), new ConcreteComponent2("Comp2") });
        }

        public Product GetProduct() => _product;
    }
}
