using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.UserHandling
{
    public class AdminUser : User
    {
        private readonly string userGroup = "Admin";

        public override ProfileInformationData getProfileInformation(Profile profile)
        {
            return new AccountInformation();
        }

        public override void ValidateAccessRights()
        {
            Console.WriteLine("I am an admin user. I can do whatever I want.");
        }
    }
}
