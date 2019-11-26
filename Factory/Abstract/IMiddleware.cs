using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Abstract
{
    //The interface that will abstract the use of the concrete classes
    public interface IMiddleware
    {
        void DoAction();
    }
}
