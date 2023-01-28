using System;
using Factory.Products;

namespace Factory.Factory
{
    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}

