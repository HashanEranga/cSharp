using System;
using Factory.Products;

namespace Factory.Factory
{
    public interface ICreator
    {
        IProduct FactoryMethod();
    }
}

