using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Solution
{
    public class MortageLoanValidator : Validator
    {
        public Boolean IsValid(User user)
        {
            return true;
        }
    }
}
