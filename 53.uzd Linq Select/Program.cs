using System;
using System.Collections.Generic;
using System.Linq;


namespace _53.uzd_Linq_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            var author1 = new Author()
            {
                Name = "Pumpurs"
            };

            var author2 = new Author()
            {
                Name = "Nosovs"
            };

            var books = new List<Book>()
            {
               new Book()
               {
                   Title = "Nezinitis",
                   PublishingYear = 1998,
                   Author = author2
               },

               new Book()
               {
                   Title = "Nezinitis Saules pilseta",
                   PublishingYear = 2005,
                   Author = author2
               },

               new Book()
               {
                   Title = "Dveselu putenis",
                   PublishingYear = 2011,
                   Author = author1
               },

            };

            var booksLaterThan2000 = books.Where(y => y.PublishingYear > 2000);

            foreach (var book in booksLaterThan2000)
            {
                Console.WriteLine($"{book.Author.Name} {book.Title} {book.PublishingYear}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            var booksByTitle = books.Where(b => b.Title.Contains("Nezin"));

            foreach (var book in booksByTitle)
            {
                Console.WriteLine($"{book.Author.Name} {book.Title} {book.PublishingYear}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            var Author = books.Where(b => b.Author.Name.Contains("Pump"));

            foreach (var book in Author)
            {
                Console.WriteLine($"{book.Author.Name} {book.Title} {book.PublishingYear}");
            }
        }
    }
}
// Uztaisīt programmu, kurā var pievienot grāmatas (Title, Author, PublishYear). 
// Autoram ir jābūt definētai kā klasei. Pievienot vismaz divas grāmatas, un izmantojot LINQ atrast grāmatas, 
// kuras ir publicētas pēc 2000. gada. 
// Izmantojot LINQ atrast grāmatu pēc nosaukuma. 
// Izmantojot LINQ atrast grāmatu ar specifisku autoru.