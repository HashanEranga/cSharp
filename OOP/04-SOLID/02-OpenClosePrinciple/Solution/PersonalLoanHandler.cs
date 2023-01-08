using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Solution
{
    public class PersonalLoanHandler
    {
        private Validator _validator;

        public PersonalLoanHandler(Validator validator)
        {
            _validator = validator;
        }

        public void ApproveLoan(User user)
        {
            if (_validator.IsValid(user)) Console.WriteLine("Personal Loan Approved");
        }
    }
}
