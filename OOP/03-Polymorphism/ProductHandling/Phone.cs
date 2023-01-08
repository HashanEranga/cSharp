using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.ProductHandling
{
    public class Phone : ProductItem
    {
        public Phone(string _name) : base(_name)
        {
            Console.WriteLine("Phone Constructor called!");
        }

        public void Ring()
        {
            Console.WriteLine("Mobile Phone Rings!");
        }

        public override ProductItem[] ListVariants()
        {
            return new ProductItem[4];
        }

        public int CalculateAmountOfVariants()
        {
            return base.ListVariants().Count();
        }
    }
}
