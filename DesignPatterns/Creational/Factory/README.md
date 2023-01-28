## Factory Pattern

In this example, the IFactory interface defines a factory method CreateProduct() that returns an object of type IProduct. The ConcreteFactoryA and ConcreteFactoryB classes implement the IFactory interface and override the CreateProduct() method to return an instance of ConcreteProductA and ConcreteProductB, respectively. The IProduct is an interface and ConcreteProductA and ConcreteProductB are concrete classes that implement the IProduct interface.

```
    public interface ICreator
    {
        IProduct FactoryMethod();
    }

    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public interface IProduct
    {
        string GetName();
    }

    public class ConcreteProductA : IProduct
    {
        public string GetName()
        {
            return "Product A";
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string GetName()
        {
            return "Product B";
        }
    }

```

This way, you can create any number of concrete classes that implements the IProduct interface and factory class that implements the IFactory interface. The factory classes can be used to create objects of the product classes without having to specify the exact class of the object that will be created.

```
ICreator creatorA = new ConcreteCreatorA();
IProduct productA = creatorA.FactoryMethod();
Console.WriteLine(productA.GetName()); 

ICreator creatorB = new ConcreteCreatorB();
IProduct productB = creatorB.FactoryMethod();
Console.WriteLine(productB.GetName());

```