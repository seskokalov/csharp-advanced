using System;

namespace Exercise4
{
    class Program
    {
        public delegate bool MyDelegate(string first, string second);

        static void Main(string[] args)
        {
            string first = "This is the first string";
            string second = "This is the second string";

            Func<string, string, bool> stringCompare = (first, second) => first.Length > second.Length;
            Func<string, string, bool> stringCompareFirstLetter = (first, second) => first[0] == second[0];
            Func<string, string, bool> stringCompareLastLetter = (first, second) => first[first.Length - 1] == second[second.Length - 1];           

            MyDelegate firstDelegate = new MyDelegate(stringCompare);
            MyDelegate secondDelegate = new MyDelegate(stringCompareFirstLetter);
            MyDelegate thirdDelegate = new MyDelegate(stringCompareLastLetter);

            StringMagic(first, second, firstDelegate);
            StringMagic(first, second, secondDelegate);
            StringMagic(first, second, thirdDelegate);

            Console.ReadLine();

        }
        public static bool StringMagic(string firstString, string secondString, MyDelegate mainDelegate)
        {
            return mainDelegate(firstString, secondString);
        }
   
    }
}
