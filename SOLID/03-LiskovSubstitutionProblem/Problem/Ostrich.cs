using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.LiskovSubstitutionProblem.Problem
{
    public class Ostrich : Bird
    {
        public void Eat()
        {
            Console.WriteLine("Ostrich Eats");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
