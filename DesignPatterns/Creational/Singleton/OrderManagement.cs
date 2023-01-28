namespace DesignPatterns.Creational.Singleton {

    public class OrderManagement{
        private static OrderManagement? _instance;

        private OrderManagement(){}

        public static OrderManagement Instance {
            get{
                if(_instance == null){
                    _instance = new OrderManagement();
                }
                return _instance;
            }
        }

        public void placeOrder(){
            Console.WriteLine("Order Placed.");
        }
    }
}