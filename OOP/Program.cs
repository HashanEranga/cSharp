using OOP.Classes.typesofclasses.Abstract;
using OOP.Classes.typesofclasses.Concrete;
using OOP.Classes.typesofclasses.Sealed;
using OOP.Classes.typesofclasses.Static;

// using concrete classes
Person hashan = new("Hashan", "Eranga", 25);
Person ishini = new("Ishini", "Amasha", 21);
Console.WriteLine(hashan.ToString());
Console.WriteLine(ishini.ToString());

// static class demo 
double answer = MathUtil.CalculateCircleArea(12.9);
Console.WriteLine($" Answer for the area of the circle {answer}");

// abstract class demo
MasterProduct masterItem_1 = new MasterProduct("MasterItem01", 100, true);
MasterProduct masterItem_2 = new MasterProduct("MasterItem02", 200, true);
Console.WriteLine(masterItem_1.ToString());
Console.WriteLine(masterItem_2.ToString());

// using sealed class demo
Mobile Nokia = new("Nokia", "Nokia Description");
Mobile Samsung = new("Samsung", "Samsung Description");
Console.WriteLine(Nokia.ToString());
Console.WriteLine(Samsung.ToString());






Console.ReadLine();