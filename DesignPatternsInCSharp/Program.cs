using Factory;
using Factory.Abstract;
using Memento;
using System;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactoryPattern();

            TestMementoPattern();
        }

        static void TestFactoryPattern()
        {
            Console.WriteLine("TESTING THE FACTORY DESIGN PATTERN: ");

            var middlewareFactory = new MiddlewareFactory();

            IMiddleware middleware = middlewareFactory.GetMiddleware(1);

            middleware.DoAction(); 

            middleware = middlewareFactory.GetMiddleware(2);

            middleware.DoAction(); 

            Console.ReadKey();
        }

        static void TestMementoPattern()
        {
            Console.WriteLine("TESTING THE MEMENTO DESIGN PATTERN: ");

            Originator<StateObject> current = new Originator<StateObject>();
            current.SetState(new StateObject { Id = 1, Name = "Object 1" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 2, Name = "Object 2" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 3, Name = "Object 3" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            Console.WriteLine("Restoring the first state");

            CareTaker<StateObject>.RestoreState(current, 0);
            current.ShowState();

            Console.ReadKey();
        }

    }
}
