using OOP.Classes.typesofclasses.Abstract;
using OOP.Classes.typesofclasses.Concrete;
using OOP.Classes.typesofclasses.Sealed;
using OOP.Classes.typesofclasses.Static;
using OOP.Encapsulation;
using OOP.Polymorphism.ArchiverHandling;
using OOP.Polymorphism.PaymentProcessor;
using OOP.Polymorphism.UserHandling;

// using concrete classes
Person hashan = new("Hashan", "Eranga", 25);
Person ishini = new("Ishini", "Amasha", 21);
Console.WriteLine(hashan.ToString());
Console.WriteLine(ishini.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// static class demo 
double answer = MathUtil.CalculateCircleArea(12.9);
Console.WriteLine($"Answer for the area of the circle {answer}");

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// abstract class demo
MasterProduct masterItem_1 = new MasterProduct("MasterItem01", 100, true);
MasterProduct masterItem_2 = new MasterProduct("MasterItem02", 200, true);
Console.WriteLine(masterItem_1.ToString());
Console.WriteLine(masterItem_2.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// using sealed class demo
Mobile Nokia = new("Nokia", "Nokia Description");
Mobile Samsung = new("Samsung", "Samsung Description");
Console.WriteLine(Nokia.ToString());
Console.WriteLine(Samsung.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// using encapsulation in c#
Student stuHashan = new("Hashan", "Eranga", 25, 23, 3.1);
Student stuIshini= new("Ishini", "Amasha", 21, 54, 3.6);
Console.WriteLine(stuHashan.ToString());
Console.WriteLine(stuIshini.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// polymorphism abstract classes
User contentManager = new ContentManager();
User admin = new AdminUser();

contentManager.ValidateAccessRights();
admin.ValidateAccessRights();

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

contentManager.getProfileInformation(new UserProfile());

// Polimorphism Interfaces
IArchiver zipArchiver = new ZipArchiver();
IArchiver rarArchiver = new RarArchiver();

zipArchiver.ArchiveFiles();
rarArchiver.ArchiveFiles();

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// Interfacing 
Client client = new Client();
ChasePaymentProcessor chPay = new();

client.SetPaymentProcessor(chPay);


PaymentData pData = new();
chPay.ValidatePayment();
client.CheckOut(pData);

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

PaypalPaymentProcessor palPay = new();
client.SetPaymentProcessor(palPay);
client.CheckOut(pData);

Console.ReadLine();