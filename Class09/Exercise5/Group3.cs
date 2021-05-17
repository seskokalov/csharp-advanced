using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Group3
    {
        public string Name { get; set; }
        public Group3(string name)
        {
            Name = name;
        }
        public void GroupThree(string message)
        {
            Console.WriteLine($"Facebook message received {message}");
        }
    }
}
