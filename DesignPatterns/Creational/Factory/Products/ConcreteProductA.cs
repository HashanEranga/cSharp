using System;
namespace Factory.Products
{
    public class ConcreteProductA : IProduct
    {
        public string GetName()
        {
            return "Product A";
        }
    }
}

