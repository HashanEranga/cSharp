using System;
namespace OOP.Classes.typesofclasses.Abstract
{
    public class VariantProduct : Product
    {
        public VariantProduct(string prodName, int minOrderCount, bool isDeliveryAvaiable) : base(prodName, minOrderCount, isDeliveryAvaiable)
        {
        }

        public override bool isAvailableInStocks()
        {
            if (1000 - base.getRemainingAmount() > 200) return true;
            else return false;
        }
    }
}

