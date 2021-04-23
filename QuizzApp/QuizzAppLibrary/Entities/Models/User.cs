using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppLibrary.Entities.Models
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
    }
}
