using Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concrete
{
    //The subject to be accessed through a proxy object
    public class RealSubject : ISubject
    {
        public void Request() => Console.WriteLine("Request from RealSubject");
    }
}
