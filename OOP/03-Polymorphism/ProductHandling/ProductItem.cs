using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.ProductHandling
{
    public class ProductItem
    {
        private int nextId = 0;
        private int Id;

        public string? Name { get; set; }

        public int CalculateRemainingAmount()
        {
            return 100;
        }

        public virtual ProductItem[] ListVariants()
        {
            return new ProductItem[3];
        }

        public ProductItem(string _name)
        {
            Name = _name;
            Id = ++nextId;
        }
    }
}
