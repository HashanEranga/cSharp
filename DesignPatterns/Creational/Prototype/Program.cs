using Prototype.Prototype;

ConcreteProtoType prototype = new ConcreteProtoType { X = 1, Y = 2 };
ConcreteProtoType clone = (ConcreteProtoType)prototype.Clone();
Console.WriteLine(clone.X); // Output: 1
Console.WriteLine(clone.Y); // Output: 2

Console.ReadKey();