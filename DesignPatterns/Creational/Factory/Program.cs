using Factory.Factory;
using Factory.Products;

ICreator creatorA = new ConcreteCreatorA();
IProduct productA = creatorA.FactoryMethod();
Console.WriteLine(productA.GetName()); 

ICreator creatorB = new ConcreteCreatorB();
IProduct productB = creatorB.FactoryMethod();
Console.WriteLine(productB.GetName());

Console.ReadKey();