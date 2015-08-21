using BookShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShopSystem.Services.Models
{
    public class AuthorViewModel
    {
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }

    public class BooksViewModel
    {
        public string Author { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}