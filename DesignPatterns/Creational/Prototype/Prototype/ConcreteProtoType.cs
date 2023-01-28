using System;
namespace Prototype.Prototype
{
    public class ConcreteProtoType : IPrototype
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ConcreteProtoType() { }

        public IPrototype Clone()
        {
            return new ConcreteProtoType { X = this.X, Y = this.Y };
        }
    }
}

