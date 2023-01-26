using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.LiskovSubstitutionProblem.Solution
{
    public interface FlyingCreature : Creature
    {
        public void Fly();
    }
}
