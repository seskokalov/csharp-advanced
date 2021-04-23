using QuizzAppLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppLibrary.Entities.Models
{
    public class Student : User
    {
        public Roles Role { get; set; }
        public List<Answers> Answers { get; set; }/* = new List<Answers>() { };*/
        public Grades TestGrade { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string username, string password) 
            : base(firstName, lastName, username, password)
        {
            Role = Roles.Student;
            Answers = new List<Answers>() { };
            TestGrade = Grades.NoGrade;
        }
    }
}
