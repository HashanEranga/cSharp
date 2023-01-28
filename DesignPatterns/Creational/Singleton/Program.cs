using DesignPatterns.Creational.Singleton;

OrderManagement order1 = OrderManagement.Instance;
OrderManagement order2 = OrderManagement.Instance;

Console.WriteLine(order1 == order2);