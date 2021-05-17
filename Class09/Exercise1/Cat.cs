using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }
        public Cat()
        {

        }
        public Cat(bool isLazy, string name, int age, string color) 
            : base(name, age, color)
        {
            IsLazy = isLazy;
        }

        public static void Meow()
        {
            Console.WriteLine("The cat says MEOW!!");
        }
    }
}
