using System;
namespace OOP.Classes.typesofclasses.Static
{
    public class MathUtil
    {
        public static double PI = 3.142;

        public static double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}

