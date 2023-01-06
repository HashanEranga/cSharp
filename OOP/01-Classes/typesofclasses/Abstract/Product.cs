using System;
namespace OOP.Classes.typesofclasses.Abstract
{
    public abstract class Product
    {
        // Properties
        private int nextId = 0;
        private int id;
        public string ProdName { get; set; }
        public int MinOrderQuantity { get; set; }
        public Boolean IsDeliveryAreaAvailable { get; set; }

        // Constructors
        public Product(string prodName, int minOrderCount, Boolean isDeliveryAvaiable)
        {
            id = ++nextId;
            ProdName = prodName;
            MinOrderQuantity = minOrderCount;
            IsDeliveryAreaAvailable = isDeliveryAvaiable;
        }

        // Methods
        public double getRemainingAmount()
        {
            return 100;
        }

        // Abstract Methods
        public abstract Boolean isAvailableInStocks();

        public override string ToString()
        {
            return $"Product id : {id}, Product Name : {ProdName}, Minimum Order Count : {MinOrderQuantity}, Delivery Area available : {IsDeliveryAreaAvailable}";
        }
    }
}

