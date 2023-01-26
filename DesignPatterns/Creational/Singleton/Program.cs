using DesignPatterns.Creational.Singleton;

OrderManagement order1 = OrderManagement.getInstance();
OrderManagement order2 = OrderManagement.getInstance();

Console.WriteLine(order1 == order2);