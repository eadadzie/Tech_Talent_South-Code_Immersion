using System;
using System.Collections.Generic;
using System.Linq;
using Week_6_Code.Models;

namespace Week_6_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<int>();
            list.Add(item: 1);
            list.Add(item: 2);
            list.Add(item: 3);
            list.Add(item: 5);
            list.Add(item: 6);
            list.Add(item: 13);

            List<int> evenNumbers = list.FindAll(num => num % 2 == 0);

            foreach (int num in list)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            evenNumbers.ForEach(Console.WriteLine);


            var bookRepository = new BookRepository();

            // fetch all the books currently in the repo
            List<Book> books = (List<Book>)bookRepository.Books;

            List<Book> lessThanTenDollars = books.FindAll(book => book.Price < 10);

            lessThanTenDollars.ForEach(book => 
                Console.WriteLine($"{book.Title} : {book.Price}"));

            // using the example on slide 17 also works
            //var bookRepository = new BookRepository();
            var books:IEnumerable < Book > = bookRepository.Books;

            var cheapBooks:IOrderedEnumerable<Book> = books
                .Where(book => book.Price < 10)
                .OrderBy(keySelector: book => book.Title);

            foreach (var cheapbook in cheapBooks)
            {
                Console.WriteLine($"{cheapbook.Title}: {cheapbook.Price}");
            }

            Book book = books.Single(predicate:b: Book => b.Title == "ASP.NET MVC"); 
            Console.WriteLine(book.Title); 
            
            var maxPrice:float = books.Max(selector: book => book.Price);
            var max = 0f;

            foreach (var b:Book in books) {
                if (book.Price > max)
                {
                    max = book.Price;
                }
            }


            string[] name = { "Bill", "Steve", "James", "Mogan" };

            var namesWithLetterA:IEnumerable<string> = 
                namespace.Where(name:string => namespace.Contains('a'));

        }   
            
    }
}
