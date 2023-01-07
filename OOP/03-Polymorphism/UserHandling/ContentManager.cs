using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.UserHandling
{
    public class ContentManager : User
    {
        public override ProfileInformationData getProfileInformation(Profile profile)
        {
            return new AccountInformation();
        }

        public override void ValidateAccessRights()
        {
            Console.WriteLine("I am a content manager. I have no enough rights.");
        }
    }
}
