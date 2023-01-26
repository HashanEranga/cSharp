using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.LiskovSubstitutionProblem.Problem
{
    public class Sparrow : Bird
    {
        public void Eat()
        {
            Console.WriteLine("Sparrow Eats");
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow Flies");
        }
    }
}
