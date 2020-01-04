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
using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;
using System;
using CommandPattern.Concrete;
using CommandPattern.Abstract;
using IteratorPattern.Concrete;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            string option = ChooseDesignPattern();

            while (!int.TryParse(option, out _) || int.Parse(option) < 1 || int.Parse(option) > 14)
            {
                Console.WriteLine("Invalid option.");

                option = Console.ReadLine();
            }

            var success = option switch
            {
                "1" => TestFactoryPattern(),
                "2" => TestMementoPattern(),
                "3" => TestBuilderPattern(),
                "4" => TestPrototypePattern(), 
                "5" => TestAdapterPattern(),
                "6" => TestBridgePattern(),
                "7" => TestCompositePattern(),
                "8" => TestDecoratorPattern(),
                "9" => TestFacadePattern(),
                "10" => TestProxyPattern(),
                "11" => TestChainOfResponsibility(),
                "12" => TestCommandPattern(),
                "13" => TestIteratorPattern(),
                   _ => false,
            };

            Console.ReadKey();

        }

        static string ChooseDesignPattern()
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
            Console.WriteLine("11 - Chain of Responsibility");
            Console.WriteLine("12 - Command");
            Console.WriteLine("13 - Iterator");
            Console.WriteLine("14 - EXIT!");

            return Console.ReadLine();
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("An error ocurred during execution:");
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }

        static bool TestFactoryPattern()
        {
            Console.WriteLine("TESTING THE FACTORY DESIGN PATTERN: ");

            var middlewareFactory = new MiddlewareFactory();

            IMiddleware middleware = middlewareFactory.GetMiddleware(1);

            middleware.DoAction();

            middleware = middlewareFactory.GetMiddleware(2);

            middleware.DoAction();

            return true;
        }

        static bool TestMementoPattern()
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

            return true;
        }

        static bool TestBuilderPattern()
        {
            Console.WriteLine("TESTING THE BUILDER DESIGN PATTERN: ");

            Director director = new Director();

            IBuilder b1 = new ConcreteBuilder1();
            IBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Console.WriteLine(b1.GetProduct());

            director.Construct(b2);
            Console.WriteLine(b2.GetProduct());

            return true;
        }

        static bool TestPrototypePattern()
        {
            Console.WriteLine("TESTING THE PROTOTYPE PATTERN: ");

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

            return true;
        }

        static bool TestAdapterPattern()
        {
            Console.WriteLine("TESTING THE ADAPTER DESIGN PATTERN: ");

            ITarget t = new SomeTarget();
            t.Request();
            //OUTPUTS
            //Request from SomeTarget

            ITarget t2 = new Adapter();//<- Adapts the incompatible object so it can be used as ITarget
            t2.Request();
            //OUTPUTS
            //Request from Adaptee

            return true;
        }

        static bool TestBridgePattern()
        {
            Console.WriteLine("TESTING THE BRIDGE DESIGN PATTERN: ");

            Abstraction abstraction = new DerivedAbstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();
            //Outputs "Method called from ConcreteImplementorA"

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
            //Outputs "Method called from ConcreteImplementorB"

            return true;
        }

        static bool TestCompositePattern()
        {
            Console.WriteLine("TESTING THE COMPOSITE DESIGN PATTERN: ");

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

            return true;
        }

        static bool TestDecoratorPattern()
        {
            Console.WriteLine("TESTING THE DECORATOR DESIGN PATTERN: ");

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

            return true;
        }

        static bool TestFacadePattern()
        {
            Console.WriteLine("TESTING THE FACADE DESIGN PATTERN: ");

            Facade facade = new Facade();
            facade.CallOperationsUnified();
            //Output:
            //Operation from ClassOne
            //Operation from ClassTwo
            //Operation from ClassThree

            return true;
        }

        static bool TestProxyPattern()
        {
            Console.WriteLine("TESTING THE PROXY DESIGN PATTERN: ");

            ISubject subject = new ProxySubject();
            subject.Request();

            return true;
        }

        static bool TestChainOfResponsibility()
        {
            Console.WriteLine("TESTING THE CHAIN OF RESPONSIBILITY DESIGN PATTERN: ");

            ChainHandler h1 = new ConcreteHandler("Handler 1");
            h1.Condition = (value) => value >= 0 && value < 5;

            ChainHandler h2 = new ConcreteHandler("Handler 2");
            h2.Condition = (value) => value >= 5 && value < 10;

            ChainHandler h3 = new ConcreteHandler("Handler 3");
            h3.Condition = (value) => value >= 10 && value < 15;

            h1.Successor = h2;
            h2.Successor = h3;


            foreach (var i in new int[] { 3, 4, 6, 11, 12 })
                h1.HandleRequest(i);

            //Output
            //Handler 1 handled the value 3
            //Handler 1 handled the value 4
            //Handler 2 handled the value 6
            //Handler 3 handled the value 11
            //Handler 3 handled the value 12

            return true;
        }

        public static bool TestCommandPattern()
        {
            Console.WriteLine("TESTING THE COMMAND DESIGN PATTERN: ");

            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker invoker = new Invoker(c);
            invoker.ExecuteCommand();
            //Output
            //Called Receiver.Action()

            return true;
        }

        public static bool TestIteratorPattern()
        {
            Console.WriteLine("TESTING THE ITERATOR DESIGN PATTERN: ");

            //Setting the concrete Iterator class for the generic Aggregate instance 
            Aggregate<Iterator> ag = new Aggregate<Iterator>();
            ag[0] = "A";
            ag[1] = "B";
            ag[2] = "C";

            //Creating the Iterator based on the Aggregate instance
            Iterator it = ag.CreateIterator() as Iterator;

            //Tracking all items through the Iterator
            object item = it.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = it.Next();
            }
            //Output:
            //A
            //B
            //C

            return true;
        }

    }
}
