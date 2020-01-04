using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Abstract
{
    public interface IAggregate
    {
        IIterator CreateIterator();
        int Count();
        object this[int index] { get; set; }
    }
}
