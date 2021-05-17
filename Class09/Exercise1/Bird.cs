using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }
        public Bird()
        {

        }
        public Bird(bool isWild, string name, int age, string color)
            : base(name, age, color)
        {
            IsWild = isWild;
        }

        public static void FlySouth(Bird bird)
        {
            Console.WriteLine(bird.IsWild ? "Flying south now!" : "I'm a caged bird :(");
        }
    }
}
