using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionProblem.Solution
{
    public class SparrowBird : Creature, FlyingCreature
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
