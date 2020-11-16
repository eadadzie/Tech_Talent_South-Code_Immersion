using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Models
{
    public class BookRepository
    {
        public IEnumerable<Book> Books { get; private set; }

        public BookRepository()
        {
            Books = new List<Book> {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
            // above and below are the same, but the above is easier to write out
            /*((List<Book>)Books).Add(new Book() {
                Title = "ADO.Net Step by Step",
                Price = 5
            });*/
        }
    }
}
