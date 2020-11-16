using System;
using System.Collections.Generic;
using System.Text;

namespace Week_6_Code.Models
{
    class BookRepository
    {
        public IEnumerable<Book> Books { get; set; }

        public BookRepository()
        {
            Books = new List<Book> {
                new Book() { Title = "ADO.Net Step by Step", Price = 5},
                new Book() { Title = "ASP.Net MVC", Price = 9.99f },
                new Book() { Title = "ASP.Net Web", Price = 7.85f }
                };
        }
    }
}
