using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.UserHandling
{
    public abstract class User
    {
        private int nextId = 0;
        private int id;
        private string? name;

        public string Name { 
            get 
            {
                if(name != null) return name;
                else return string.Empty;   
            } 
            set => name = value; 
        }

        public virtual void ValidateAccessRights()
        {
            Console.WriteLine("I am an abstract user. I don't have any specific rights.");
        }

        public abstract ProfileInformationData getProfileInformation(Profile profile);
    }
}
