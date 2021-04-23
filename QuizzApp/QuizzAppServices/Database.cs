using QuizzAppLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppServices
{
    public static class Database
    {
        public static Student ActiveStudent { get; set; }

        public static void activeSessionStudent(Student student)
        {
            ActiveStudent = student;
        }
    }
}
