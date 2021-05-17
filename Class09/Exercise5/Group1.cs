using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Group1
    {
        public string Name { get; set; }
        public Group1(string name)
        {
            Name = name;
        }

        public void GroupOne(string message)
        {
            Console.WriteLine($"SMS message received {message}");
        }
    }
}
