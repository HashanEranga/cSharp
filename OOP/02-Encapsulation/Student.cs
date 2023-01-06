using System;
using OOP.Classes.typesofclasses.Concrete;

namespace OOP.Encapsulation
{
    public class Student : Person
    {
        public Student(string fName, string lName, int age, int stuid, double gpa) : base(fName, lName, age)
        {
            StuId = stuid;
            Cgpa = gpa;
        }

        private int stuId;
        private double cgpa;

        public int StuId { get { return stuId; } set { stuId = value; } }
        public double Cgpa { get { return cgpa; } set { cgpa = value; } }

        public override string ToString()
        {
            return $"Student Id : {StuId}, Student full name : {base.FirstName} {base.LastName}, Current GPA : {Cgpa}";
        }
    }
}

