using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.SingleResponsibilirtPrinciple.Problem
{
    public class PMailUser
    {
        private int NextId = 0;
        private int Id; 

        public string? PrimaryEmail { get; set; }
        public string? SecondaryEmail { get; set; }

        public PRole Role { get; set; }

        public PMailUser(string _pMail, string _sMail, PRole _role)
        {
            PrimaryEmail = _pMail;
            SecondaryEmail = _sMail;
            Role = _role;
            Id = ++NextId;
        }

        public void SendMoney(PMailUser userTo, int dollers)
        {
            Console.WriteLine($"Send money to {userTo.Id} amount of {dollers}");
        }


    }
}
