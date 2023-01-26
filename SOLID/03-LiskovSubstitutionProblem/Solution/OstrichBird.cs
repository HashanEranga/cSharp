using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionProblem.Solution
{
    public class OstrichBird : Creature
    {
        public void Eat()
        {
            Console.WriteLine("Ostrich Eats");
        }
    }
}
