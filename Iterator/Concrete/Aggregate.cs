using IteratorPattern.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Concrete
{
    public class Aggregate<T> : IAggregate where T : IIterator, new()
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            IIterator a = new T();
            a.SetAggregate(this);
            return a;
        }

        public int Count() => _items.Count;

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
