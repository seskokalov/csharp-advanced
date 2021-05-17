using System;
using System.Collections.Generic;
using System.Text;
using Exercise1;

namespace Exercise3
{
    public class Methods
    {
        public static void PrintList<T>(List<T> list)
        {
            list.ForEach(x => Console.WriteLine(x));
        }        

        //Drugiot metod e vo exercise 1 ama ne raboti :)
    }
}
