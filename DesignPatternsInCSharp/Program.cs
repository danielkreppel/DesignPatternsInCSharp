using Builder.Abstract;
using Builder.Concrete;
using Factory;
using Factory.Abstract;
using Memento;
using PrototypeDesignPattern.Abstract;
using PrototypeDesignPattern.Concrete;
using System;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Design Pattern to test:");
            Console.WriteLine("1 - Factory");
            Console.WriteLine("2 - Memento");
            Console.WriteLine("3 - Builder");
            Console.WriteLine("4 - Prototype");
            Console.WriteLine("5 - EXIT!");

            string option = Console.ReadLine(); 

            while (!int.TryParse(option, out _) || int.Parse(option) < 1 || int.Parse(option) > 5)
            {
                Console.WriteLine("Invalid option.");

                option = Console.ReadLine();
            }

            switch (int.Parse(option))
            {
                case 1: 
                    TestFactoryPattern();
                    break;
                case 2:
                    TestMementoPattern();
                    break;
                case 3:
                    TestBuilderPattern();
                    break;
                case 4:
                    TestPrototypePattern();
                    break;
                default:
                    return;
            }
            
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

        static void TestBuilderPattern()
        {
            Console.WriteLine("TESTING THE BUILDER DESIGN PATTERN: ");

            Director director = new Director();

            IBuilder b1 = new ConcreteBuilder1();
            IBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Console.WriteLine(b1.GetProduct());

            director.Construct(b2);
            Console.WriteLine(b2.GetProduct());

            Console.ReadKey();
        }

        static void TestPrototypePattern()
        {
            var prototype = new ConcretePrototype1
            {
                Property1 = "A",
                Property2 = "B",
                PrototypeDetails = new PrototypeDetails { Details = "'prototype' details" }
            };

            //New instance using the prototype
            var NewObject = prototype.Clone() as ConcretePrototype1;
            //Without using Deep copy, the next line whould change the same PrototypeDetails instance 
            //used in 'prototype' and 'NewObject', since both would be using the same reference to this object instance
            NewObject.PrototypeDetails.Details = "New details for 'NewObject'";

            Console.WriteLine(prototype);
            Console.WriteLine(NewObject);
            //OUTPUT
            //Property1: A Property2:B PrototypeDetails:"'prototype' details"
            //Property1: A Property2:B PrototypeDetails:"New details for 'NewObject'"

            var prototype2 = new ConcretePrototype2
            {
                Property1 = "X",
                Property2 = "Y",
                OtherProperty = "Z",
                PrototypeDetails = new PrototypeDetails { Details = "'prototype2' details" }
            };

            //New instance using the prototype2
            var NewObject2 = prototype2.Clone() as ConcretePrototype2;
            NewObject2.PrototypeDetails.Details = "New details for 'NewObject2'";

            Console.WriteLine(prototype2);
            Console.WriteLine(NewObject2);
            //OUTPUT
            //Property1: X Property2:Y PrototypeDetails:"'prototype2' details" OtherProperty: Z
            //Property1:X Property2:Y PrototypeDetails:"New details for 'NewObject2'" OtherProperty: Z

            Console.ReadKey();
        }

    }
}
