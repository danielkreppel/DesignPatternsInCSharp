using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Abstract
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
        void SetAggregate(IAggregate ag);
    }
}
