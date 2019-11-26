using Factory.Abstract;
using Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class MiddlewareFactory
    {
        public IMiddleware GetMiddleware(int which)
        {
            switch (which)
            {
                case 1: return new Middleware1();
                case 2: return new Middleware2();
                default: return new Middleware1();
            }
        }
    }
}
