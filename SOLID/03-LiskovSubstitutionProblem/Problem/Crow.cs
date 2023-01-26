using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.LiskovSubstitutionProblem.Problem
{
    public class Crow : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Crow Flies");
        }

        public void Eat()
        {
            Console.WriteLine("Crow Eats");
        }
    }
}
