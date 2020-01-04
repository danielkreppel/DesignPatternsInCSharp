using IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Concrete
{
    public class Iterator : IIterator
    {
        private IAggregate _aggregate;
        private int _current = 0;

        public Iterator() { }
        public void SetAggregate(IAggregate ag) => this._aggregate = ag;

        public object First() => _aggregate[0];

        public object Next() => (_current < _aggregate.Count() - 1) ? _aggregate[++_current] : null;

        public object CurrentItem() => _aggregate[_current];

        public bool IsDone() => _current >= _aggregate.Count();
    }
}
