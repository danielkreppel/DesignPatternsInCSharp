using CompositePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Concrete
{
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }
        public override void Add(Component component) => _children.Add(component);
        public override void Remove(Component component) => _children.Remove(component);

        public override void DisplayAll(int index = 1)
        {
            Console.WriteLine($"{new String('>', index)} - {this.Name}");
            foreach (var comp in _children)
                comp.DisplayAll(index + 1);
        }
    }
}
