using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.SingleResponsibilirtPrinciple.Solution
{
    public class MailUser
    {
        private int NextId = 0;
        private int Id;

        public string? PrimaryEmail { get; set; }
        public string? SecondaryEmail { get; set; }

        public Role Role { get; set; }

        public MailUser(string _pMail, string _sMail, Role _role)
        {
            PrimaryEmail = _pMail;
            SecondaryEmail = _sMail;
            Role = _role;
            Id = ++NextId;
        }

        public void SendMoney(MailUser userTo, int dollers)
        {
            Console.WriteLine($"Send money to {userTo.Id} amount of {dollers}");
        }
    }
}
