using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Concrete
{
    public class Middleware2 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("Executing another action from Middleware 2");
        }
    }
}
