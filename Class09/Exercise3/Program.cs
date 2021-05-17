using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "We", "Are", "G4"};
            List<int> numbers = new List<int> { 5, 6, 8, 10 };

            Methods.PrintList(strings);

            Console.ReadLine();
        }
    }
}
