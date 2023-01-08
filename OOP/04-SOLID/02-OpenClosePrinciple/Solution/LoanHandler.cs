using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.OpenClosePrinciple.Solution
{
    public interface LoanHandler
    {
        public void ApproveLoan(User user);
    }
}
