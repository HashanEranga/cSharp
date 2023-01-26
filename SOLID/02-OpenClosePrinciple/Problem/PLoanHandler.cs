using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Problem
{
    public class PLoanHandler
    {
        private PPersonalLoanValidator? _personalLoanValidator = new();
        private PMortageLoanValidator? _mortageLoanValidator = new();

        public void ApprovePersonalLoan(PUser user)
        {
            if(_personalLoanValidator != null)
            {
                if(_personalLoanValidator.IsValidUserForPersonalLoan(user))
                    Console.WriteLine("Proceed with personal Loan Approval");
            }
        }

        public void ApproveMortage(PUser user)
        {
            if(_mortageLoanValidator != null)
            {
                if (_mortageLoanValidator.IsValidUserForMortage(user))
                    Console.WriteLine("Proceed with mortage load approval");
            }
        }
    }
}
