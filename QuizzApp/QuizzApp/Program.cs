using QuizzAppLibrary.Entities.Models;
using System;
using System.Collections.Generic;

namespace QuizzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initial users
            #region teachers
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Kristina", "Spasevska", "kiki123", "kiki123"),
                new Teacher("Pane", "Manaskov", "pane123", "pane123")
            };
            #endregion
            #region students
            List<Student> students = new List<Student>
            {
                new Student("Nikola", "Sheskokalov", "nikola123", "nikola123"),
                new Student("Jana", "Simjanovska", "jana123", "jana123"),
                new Student("Ivan", "Jamandilovski", "ivan123", "ivan123"),
                new Student("Marta", "Spasovska", "marta123", "marta123"),
                new Student("Ivana", "Krsteva", "ivana123", "ivana123"),
                new Student("Leart", "Kamberi", "leart123", "leart123"),
                new Student("Gjorgje", "Danilovski", "gjorgje123", "gjorgje123"),
                new Student("Sanja", "Karakashova", "sanja123", "sanja123")
            };
            #endregion
            #endregion

            try
            {
                Console.WriteLine("Quizz time!");
                Console.WriteLine("Provide your credentials below:");
                Console.WriteLine("--------------------------------");
                QuizzAppServices.AppServices.MainMenu(teachers, students);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.ReadLine();
        }
    }
}
