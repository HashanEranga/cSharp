using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionProblem.Solution
{
    public interface FlyingCreature : Creature
    {
        public void Fly();
    }
}
