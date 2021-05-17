using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise2
{
    public class Methods
    {
        public static void GetFirstLetter(string input)
        {
            char first = input[0];
            Console.WriteLine(first);
        }

        public static void GetLastLetter(string input)
        {
            char last = input[input.Length - 1];
            Console.WriteLine(last);
        }

        public static bool IsEven(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static void GetFirstItem<T>(List<T> items)
        {
            Console.WriteLine(items.FirstOrDefault());
        }
    }
}
