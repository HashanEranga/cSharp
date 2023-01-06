using System;
namespace OOP.Classes.typesofclasses.Abstract
{
    public class MasterProduct : Product
    {
        public MasterProduct(string prodName, int minOrderCount, bool isDeliveryAvaiable) : base(prodName, minOrderCount, isDeliveryAvaiable)
        {
        }

        public int ProductsCount { get; set; }

        public override bool isAvailableInStocks()
        {
            if (base.getRemainingAmount() > 0) return true;
            else return false;
        }
    }
}

