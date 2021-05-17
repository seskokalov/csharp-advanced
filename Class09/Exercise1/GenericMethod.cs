using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1
{
    public static class GenericMethod<T> where T : Animal
    {
        public static void PrintAnimals(List<T> list)
        {
            list.ForEach(x => Console.WriteLine(x.Name));
        }                
    }
}
