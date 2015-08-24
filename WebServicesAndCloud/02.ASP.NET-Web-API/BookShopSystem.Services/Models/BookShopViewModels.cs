using BookShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShopSystem.Services.Models
{
    public class AuthorViewModel
    {
        public string Author { get; set; }

        public ICollection<String> Books { get; set; }
    }

    public class BookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Descpription { get; set; }

        public decimal Price { get; set; }

        public int Copies { get; set; }

        public string Edition { get; set; }

        public String ReleaseDate { get; set; }

        public string Author { get; set; }

        public List<string> Categories { get; set; }
    }
}