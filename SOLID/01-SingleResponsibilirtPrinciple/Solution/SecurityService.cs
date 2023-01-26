using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.SingleResponsibilirtPrinciple.Solution
{
    public class SecurityService
    {
        public Boolean HasAccess(MailUser _user)
        {
            if (_user.Role == Role.ADMIN) return true;
            else return false;
        }
    }
}
