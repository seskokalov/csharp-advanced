using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Group2
    {
        public string Name { get; set; }
        public Group2(string name)
        {
            Name = name;
        }

        public void GroupTwo(string message)
        {
            Console.WriteLine($"Email message received {message}");
        }
    }
}
