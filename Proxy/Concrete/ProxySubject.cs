using Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concrete
{
    public class ProxySubject : ISubject
    {
        private Lazy<RealSubject> _realSubject = new Lazy<RealSubject>();
        public void Request() => _realSubject.Value.Request();
    }
}
