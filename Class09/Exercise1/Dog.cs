using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog()
        {

        }
        public Dog(string breed, string name, int age, string color) 
            : base( name, age, color)
        {
            Breed = breed;
        }

        public static void Bark()
        {
            Console.WriteLine($"The dog says WOOF!!");
        }
    }
}
