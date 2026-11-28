namespace KTs_CSharp
{
    public class KT6_Generative : A_KT
    {
        public override void Enter()
        {
            while (true)
            {
                Helper.CreateAnIdentation("KT6 Degenerative");
                Console.WriteLine("Select Action" +
                    "\n[1] - check" +
                    "\n[exit]");

                Helper.GetAnswer();
                switch (Helper.Answer)
                {
                    case "1":
                        Console.WriteLine("дебил придумал");
                        break;
                    default:
                        return;
                }

                return;
            }
        }
    }
}
namespace KTs_CSharp.Prototype
{
    public abstract class A_Prototype
    {
        public int Id { get; set; }
        public A_Prototype(int id)
        {
            Id = id;
        }
        public abstract A_Prototype Clone();
    }
    public class ConcretePrototype2 : A_Prototype
    {
        public ConcretePrototype2(int id) : base(id) { }

        public override A_Prototype? Clone() { return this.MemberwiseClone() as ConcretePrototype2; } // ???
    }
    public class ConcretePrototype1 : A_Prototype
    {
        public ConcretePrototype1(int id) : base(id) { }
        public override A_Prototype? Clone() { return this.MemberwiseClone() as ConcretePrototype1; } // ???
    }
    public class Client
    {
        private void Operation()
        {
            throw new NotImplementedException(); // ????
        }
    }
}

namespace KTs_CSharp.Creator
{
    public abstract class A_Creator
    {
        public abstract A_Product FactoryMethod();
    }

    public class ConcreteCreatorB : A_Creator
    {
        public override A_Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class ConcreteCreatorA : A_Creator
    {
        public override A_Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public abstract class A_Product { }

    public class ConcreteProductB : A_Product { }
    public class ConcreteProductA : A_Product { }
}

namespace KTs_CSharp.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public abstract class AbstractProductB { }
    public class ProductB2 : AbstractProductB { }
    public class ProductB1 : AbstractProductB { }

    public abstract class AbstractProductA { }
    public class ProductA2 : AbstractProductA { }
    public class ProductA1 : AbstractProductA { }

    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            // ?????????
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }
        public void Run() { } // ????????
    }
}

namespace KTs_CSharp.Builder
{
    public abstract class A_Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }
    public class ConcreteBuilder : A_Builder
    {
        private Product _product = new();
        public override void BuildPartA()
        {
            _product.Add("part1"); // мне лень думать, какая таблица такая и реализация
        }

        public override void BuildPartB()
        {
            _product.Add("part2");
        }

        public override void BuildPartC()
        {
            _product.Add("part3");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    public class Director
    {
        private A_Builder _builder;
        public Director(A_Builder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }

    public class Product
    {
        public List<Object>? Parts { get; private set; }
        public void Add(string part)
        {
            Parts?.Add(part);
        }
    }
}

namespace KTs_CSharp.Singleton
{
    public class Singleton
    {
        private static Singleton _singletonInstance = new();
        public static Singleton GetInstance() => _singletonInstance;
    }

    public class Client
    {
        public void Operation()
        {
            Singleton single = Singleton.GetInstance();
        }
    }
}
