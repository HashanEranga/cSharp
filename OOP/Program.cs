using OOP.Classes.typesofclasses.Concrete;
using OOP.Classes.typesofclasses.Static;

// using concrete classes
Person hashan = new("Hashan", "Eranga", 25);
Person ishini = new("Ishini", "Amasha", 21);
Console.WriteLine(hashan.ToString());
Console.WriteLine(ishini.ToString());

double answer = MathUtil.CalculateCircleArea(12.9);
Console.WriteLine($" Answer for the area of the circle {answer}");











Console.ReadLine();