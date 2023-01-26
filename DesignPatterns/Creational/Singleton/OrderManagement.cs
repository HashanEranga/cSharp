namespace DesignPatterns.Creational.Singleton {

    public class OrderManagement{
        private static OrderManagement? instance;

        private OrderManagement(){}

        public static OrderManagement getInstance(){
            if (instance == null) instance = new();
            return instance;
        }

        public void placeOrder(){
            Console.WriteLine("Order Placed.");
        }
    }
}