using System;

namespace Memento
{
    //This is the object to keep state in memento. 
    //It needs to implement ICloneable interface to provide a deep copy object,
    //otherwise the memento could be filled with shallow copies with references to the same object in memory
    public class StateObject : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new StateObject
            {
                Id = this.Id,
                Name = this.Name
            };
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}";
        }
    }
}
