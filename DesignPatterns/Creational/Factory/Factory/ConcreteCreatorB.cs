using System;
using Factory.Products;

namespace Factory.Factory
{
    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}

