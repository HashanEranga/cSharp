using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.LiskovSubstitutionProblem.Solution
{
    public class CrowBird : Creature, FlyingCreature
    {
        public void Eat()
        {
            Console.WriteLine("Crow Eats");
        }

        public void Fly()
        {
            Console.WriteLine("Crow Flies");
        }
    }
}
