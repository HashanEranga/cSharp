using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.SingleResponsibilirtPrinciple.Solution
{
    public class MailBoxSettingsService
    {
        private SecurityService securityService = new();
        public void ChangePrimaryEmail(MailUser _user, string _newPrimaryEmail)
        {
            if (securityService.HasAccess(_user))
            {
                _user.PrimaryEmail = _newPrimaryEmail;
            }
        }
    }
}
