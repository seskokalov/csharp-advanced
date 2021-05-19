using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();

            List<int> howManyAuthors = authors
                                        .Select(x => x.ID)
                                        .ToList();
            Console.WriteLine($"There are a total of {howManyAuthors.Count} authors");
            List<Book> howManyBooks = authors
                                .SelectMany(x => x.Books)
                                .ToList();

            Console.WriteLine($"There is a total of {howManyBooks.Count} books");
            Console.WriteLine("------------------------------------------------");

            //-How many books are collaborations(have more than one author)?         
            var howManyBooksAreCollaborations = authors
                                                .SelectMany(x => x.Books)
                                                .GroupBy(x => x.ID)
                                                .Where(x => x.Count() > 1)
                                                .ToList();
            Console.WriteLine($"Number of books that are collaborations are: {howManyBooksAreCollaborations.Count()}");
            Console.WriteLine("------------------------------------------------");

            //-Which book has the most authors(and how many) ?
            var authorCollaborations = howManyBooksAreCollaborations
                                            .OrderByDescending(x => x.Count())
                                            .FirstOrDefault();
            Book nameOftheBook = authorCollaborations
                                            .FirstOrDefault();
            Console.WriteLine($"The book with most collaborations is: {nameOftheBook.Title} with number of collaborations: {authorCollaborations.Count()}");
            Console.WriteLine("------------------------------------------------");

            //-What author wrote most collaborations ? "
            var colaborationBooks = authors
                                    .SelectMany(x => x.Books)
                                    .Where(x => (howManyBooksAreCollaborations.Select(y => y.Key))
                                    .Any(z => z == x.ID))
                                    .ToList();

            var numberOfCollaborations = authors
                                    .Select(x => x.Books.Where(y => colaborationBooks.Any(z => z.ID == y.ID))
                                    .Count())
                                    .OrderBy(z => z)
                                    .LastOrDefault();

            var authorWithMostColaborations = authors
                                    .Where(x => x.Books.Where(y => colaborationBooks.Any(z => z.ID == y.ID)).Count() == numberOfCollaborations)
                                    .FirstOrDefault();
            Console.WriteLine($"Author with most collaborations is {authorWithMostColaborations.Name}, with a number of {numberOfCollaborations} collaborations");
            Console.WriteLine("------------------------------------------------");

            //-In what year were published most books in a specific genre? Which genre ?

            //-Which author has most books nominated for an award?
            Author authorWithMostNominations = authors
                                            .OrderBy(x => x.Nominations)
                                            .LastOrDefault();
            int numberOfNominations = authorWithMostNominations
                                        .Books
                                        .Select(x => x.Nominations)
                                        .Where(x => x > 0)
                                        .Count();

            Console.WriteLine($"Author with most nominations is {authorWithMostNominations.Name} with number of books nominated: {numberOfNominations}");
            Console.WriteLine("------------------------------------------------");

            //-Which author has most books that won an award ?
            Author authorWithMostBooksThatWon = authors
                                                .OrderByDescending(x => x.Books.Where(y => y.Wins > 0).Count())
                                                .FirstOrDefault();
            int authorWithMostBooksThatWonCount = authorWithMostBooksThatWon.Books.Where(x => x.Wins > 0).Count();
            Console.WriteLine($"Author {authorWithMostBooksThatWon.Name} has {authorWithMostBooksThatWonCount} books that won an award!");
            Console.WriteLine("------------------------------------------------");

            //-Which author has most books nominated for an award, without winning a single award ?
            Author authorWithMostNominationsBut0Awards = authors
                                                .Where(x => x.Wins == 0)
                                                .OrderByDescending(x => x.Nominations)
                                                .FirstOrDefault();
            Console.WriteLine($"{authorWithMostNominationsBut0Awards.Name} has 0 awards but most nominations for an award!");
            Console.WriteLine("------------------------------------------------");

            //-Make a histogram of books published per decade per genre.

            //- Which author has a highest percentage of nominated books ?


            Console.ReadLine();

        }
    }
}
