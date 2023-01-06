using System;
namespace OOP.Classes.typesofclasses.Concrete
{
    public class Person
    {
        private static int nextId = 0;
        private readonly int id;
        private string? firstName;
        private string? lastName;
        private int age;

        public string FirstName
        {
            get
            {
                if (firstName != null) return firstName;
                else return "";
            }
            set
            {
                if (value != null) firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (lastName != null) return lastName;
                else return "";
            }
            set
            {
                if (value != null) lastName = value;
            }
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public Person(string _fname, string _lname, int _age)
        {
            FirstName = _fname;
            LastName = _lname;
            Age = _age;

            id = ++nextId;
        }

        public override string ToString()
        {
            return $"Id : {id}, Name : {FirstName} {LastName}, Age : {Age}";
        }
    }
}

