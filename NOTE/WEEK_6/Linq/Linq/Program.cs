using System;
using System.Collections.Generic;
using System.Linq;

using Linq.Models;

namespace Linq
{
    class Program {
        static void Main(string[] args) {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(8);
            list.Add(13);
            List<int> evenNumbers = list.FindAll(num => num % 2 == 0);
            // this loop is the same as the findAll command above
            foreach (int num in list) {
                if (num % 2 == 0) {
                    evenNumbers.Add(num);
                }
            }
            evenNumbers.ForEach(Console.WriteLine);
            Console.WriteLine("------------------------");

            // create an instance of a book repository to store our books
            var bookRepository = new BookRepository();
            // fetch all the books currently in the repository
            var books = bookRepository.Books;

            var cheapBooks = books
                .Where(book => book.Price < 10)
                .OrderBy(book => book.Title);

            foreach (var cheapBook in cheapBooks) {
                Console.WriteLine($"{cheapBook.Title}: {cheapBook.Price}");
            }

            Book book = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book.Title);

            var maxPrice = books.Max(book => book.Price);
            // line above and the foreach below are the same:
            var max = 0f;

            foreach (var b in books) {
                if (b.Price > max) {
                    max = b.Price;
                }
            }
            
            var mixPrice = books.Min(book => book.Price);
            // line above and the foreach below are the same:
            var min = float.MaxValue;

            foreach (var b in books) {
                if (b.Price < min) {
                    min = b.Price;
                }
            }

            var totalPrice = books.Sum(book => book.Price);
            // line above and the foreach below are the same:
            var total = 0f;

            foreach (var b in books) {
                total += b.Price;
            }

            Console.WriteLine("------------------------");
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            var namesWithLetterA = 
                names.Where(name => name.Contains('a'));

            foreach (var name in namesWithLetterA) {
                Console.WriteLine($"{name}");
            }
        }

    }
}
