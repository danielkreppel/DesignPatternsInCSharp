using AdapterPattern.Abstract;
using AdapterPattern.Concrete;
using Bridge.Concrete;
using Builder.Abstract;
using Builder.Concrete;
using CompositePattern.Concrete;
using DecoratorDesignPattern.Concrete;
using FacadeDesignPattern;
using Factory;
using Factory.Abstract;
using Memento;
using PrototypeDesignPattern.Abstract;
using PrototypeDesignPattern.Concrete;
using Proxy.Abstract;
using Proxy.Concrete;
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
            Console.WriteLine("5 - Adapter");
            Console.WriteLine("6 - Bridge");
            Console.WriteLine("7 - Composite");
            Console.WriteLine("8 - Decorator");
            Console.WriteLine("9 - Facade");
            Console.WriteLine("10 - Proxy");
            Console.WriteLine("11 - EXIT!");

            string option = Console.ReadLine();

            while (!int.TryParse(option, out _) || int.Parse(option) < 1 || int.Parse(option) > 11)
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
                case 5:
                    TestAdapterPattern();
                    break;
                case 6:
                    TestBridgePattern();
                    break;
                case 7:
                    TestCompositePattern();
                    break;
                case 8:
                    TestDecoratorPattern();
                    break;
                case 9:
                    TestFacadePattern();
                    break;
                case 10:
                    TestProxyPattern();
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

        static void TestAdapterPattern()
        {
            ITarget t = new SomeTarget();
            t.Request();
            //OUTPUTS
            //Request from SomeTarget

            ITarget t2 = new Adapter();//<- Adapts the incompatible object so it can be used as ITarget
            t2.Request();
            //OUTPUTS
            //Request from Adaptee

            Console.ReadKey();
        }

        static void TestBridgePattern()
        {
            Abstraction abstraction = new DerivedAbstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();
            //Outputs "Method called from ConcreteImplementorA"

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
            //Outputs "Method called from ConcreteImplementorB"

            Console.ReadKey();
        }

        static void TestCompositePattern()
        {
            Composite composite = new Composite("First");
            composite.Add(new Composite("Second"));
            composite.Add(new Composite("Third"));
            Composite composite1 = new Composite("Forth");
            composite1.Add(new Composite("Fifth"));
            composite1.Add(new Composite("Sixth"));
            composite.Add(composite1);

            composite.DisplayAll();
            //Will output the Composite name and its 
            //chidrens names (hierarchically) in a recursive way:
            //> - First
            //>> - Second
            //>> - Third
            //>> - Forth
            //>>> - Fifth
            //>>> - Sixth

            Console.ReadKey();
        }

        static void TestDecoratorPattern()
        {
            ConcreteComponent comp = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA(comp);
            ConcreteDecoratorB d2 = new ConcreteDecoratorB(d1);

            comp.Operation();
            //Output:
            //Operation from ConcreteComponent

            d1.Operation();
            //Output:
            //Operation from ConcreteComponent
            //(AddedBehaviour A) + Operation from ConcreteDecoratorA

            d2.Operation();
            //Output:
            //Operation from ConcreteComponent
            //(AddedBehaviour A) + Operation from ConcreteDecoratorA
            //(AddedBehaviour B) + Operation from ConcreteDecoratorB

            Console.ReadKey();
        }

        static void TestFacadePattern()
        {
            Facade facade = new Facade();
            facade.CallOperationsUnified();
            //Output:
            //Operation from ClassOne
            //Operation from ClassTwo
            //Operation from ClassThree

            Console.ReadKey();
        }

        static void TestProxyPattern()
        {
            ISubject subject = new ProxySubject();
            subject.Request();

            Console.ReadKey();
        }
    }
}
