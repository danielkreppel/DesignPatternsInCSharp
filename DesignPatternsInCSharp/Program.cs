using Factory;
using Factory.Abstract;
using System;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactoryPattern();
        }

        static void TestFactoryPattern()
        {
            Console.WriteLine("TESTING THE FACTORY PATTERN: ");
            var middlewareFactory = new MiddlewareFactory();
            IMiddleware middleware = middlewareFactory.GetMiddleware(1);
            middleware.DoAction(); 

            middleware = middlewareFactory.GetMiddleware(2);
            middleware.DoAction(); 

            Console.ReadKey();
        }
    }
}
