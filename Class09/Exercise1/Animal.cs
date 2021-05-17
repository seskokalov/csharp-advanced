using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int _age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 175)
                {
                    Console.WriteLine("Invalid age");
                    return;
                }
                else
                {
                    _age = value;
                }

            }
        }
        public string Color { get; set; }

        public Animal()
        {

        }
        public Animal(string name, int age, string color)
        {
            Name = name;
            _age = age;
            Color = color;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"The animal {Name} has {_age} and it is of {Color} color");
        }
    }
}
