using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Solution
{
    public class MortageHandler : LoanHandler
    {
        private Validator _validator;

        public MortageHandler(Validator validator)
        {
            _validator = validator;
        }

        public void ApproveLoan(User user)
        {
            if (_validator.IsValid(user)) Console.WriteLine("Mortage loan Approved");
        }
    }
}
