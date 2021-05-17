using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Animal lists
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Labrador", "Sofi", 6, "Black"),
                new Dog("Dzukela", "Sharko", 13, "Shareno"),
                new Dog("Shar Pei", "Pero", 2, "Brown")
            };

            List<Cat> cats = new List<Cat>
            {
                new Cat(true, "Dimce", 4, "Gray"),
                new Cat(false, "Fluffy", 1, "Yellow"),
                new Cat(true, "Ace", 7, "Black")
            };

            List<Bird> birds = new List<Bird>
            {
                new Bird(true, "Bezimenko", 2, "Black"),
                new Bird(false, "Petre", 1, "Red"),
                new Bird(true, "NoName", 10, "Yellow")
            };

            #endregion

            List<Dog> getDogs = dogs
                                .Where(x => x.Breed == "Labrador")
                                .ToList();
            Console.WriteLine($"Labrador dogs are:");
            getDogs.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine("--------------------------------");

            Cat getLastLazyCat = cats
                                .Where(x => x.IsLazy == true)
                                .LastOrDefault();
            Console.WriteLine("Lazy cats are:");
            Console.WriteLine(getLastLazyCat.Name);
            Console.WriteLine("--------------------------------");

            List<Bird> getBirds = birds
                                .Where(x => x._age < 3)
                                .OrderBy(y => y.Name)
                                .ToList();
            Console.WriteLine("Birds younger than 3 and ordered by name are:");
            getBirds.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine("--------------------------------");

            getLastLazyCat.PrintInfo();

            //ne znam zaso ne raboti
            //GenericMethod.PrintAnimals(dogs);
            

            Console.ReadLine();
        }
    }
}
