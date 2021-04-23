using QuizzAppLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppLibrary.Entities.Models
{
    public class Student : User
    {
        public Roles Role { get; set; }
        public Dictionary<int, Answers> Answers { get; set; } = new Dictionary<int, Answers>() { };
        public Grades TestGrade { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string username, string password) 
            : base(firstName, lastName, username, password)
        {
            Role = Roles.Student;
            TestGrade = Grades.NoGrade;
        }
    }
}
