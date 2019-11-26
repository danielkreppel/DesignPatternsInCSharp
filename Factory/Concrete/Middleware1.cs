using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Concrete
{
    public class Middleware1 : IMiddleware
    {
        //Implementing the interface method
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware 1");
        }
    }
}
