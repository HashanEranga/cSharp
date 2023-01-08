using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.SingleResponsibilirtPrinciple.Problem
{
    public class PMailBoxSettingsService
    {
        public void ChangePrimaryEmail(PMailUser _user, string _newPrimaryEmail)
        {
            if (HasAccess(_user)) _user.PrimaryEmail = _newPrimaryEmail;
        }

        public void ChangeSecondaryEmail(PMailUser _user, string _newSecondaryEmail)
        {
            if (HasAccess(_user)) _user.SecondaryEmail = _newSecondaryEmail;
        }

        public Boolean HasAccess(PMailUser user)
        {
            if(user.Role == PRole.ADMIN) return true;
            else return false;
        }
    }
}
