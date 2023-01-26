using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Solution
{   
    public class PersonalLoanValidator : Validator
    {
        public Boolean IsValid(User user)
        {
            return true;
        }
    }
}
