using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string workString = "GetFirstLetter - Method on String that returns the first letter of a string";
            int workInt = 9;
            List<int> numbers = new List<int>{ 1, 2, 3, 4, 5};

            Methods.GetFirstLetter(workString);
            Methods.GetLastLetter(workString);
            Console.WriteLine(Methods.IsEven(workInt));
            Methods.GetFirstItem(numbers);



            Console.ReadLine();
        }
    }
}
