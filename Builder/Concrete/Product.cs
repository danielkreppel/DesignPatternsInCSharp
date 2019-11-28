using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Concrete
{
    public class Product
    {
        private List<IComponent> _components = new List<IComponent>();

        public void AddComponents(List<IComponent> comps) => _components.AddRange(comps);
        public override string ToString() => "Product components: \n" + string.Join(" \n", _components);

    }
}
