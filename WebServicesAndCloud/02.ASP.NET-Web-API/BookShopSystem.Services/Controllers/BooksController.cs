using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using BookShopSystem.Data;
using BookShopSystem.Services.Models;

namespace BookShopSystem.Services.Controllers
{
    /*    
    GET	/api/books/{id}	Gets data about a book by id. Returns all data about the book + category names + author name and id.	   
    GET	/api/books?search={word}	Gets top 10 books which contain the given substring, sorted by title (ascending). Returns only the title and id of the books.	   
    PUT	/api/books/{id}	Edits the book. Receives book title, description, price, copies, edition, age restriction, release date and author id.	   
    DELETE	/api/books/{id}	Deletes the book.	   
    POST	/api/books	Adds a new book with title, description, price, copies, edition, age restriction, release date and a string with space-separated category names.	 
    */

    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        [Route("{id}")]
        public IHttpActionResult GetBookInfo(int id)
        {
            var context = new BookShopContext();
            var book = context.Books.Find(id);

            if (book == null)
                return this.BadRequest("Book does not exist.");

            var returnValue = new BookViewModel()
            {
                Id = id,
                Title = book.Title,
                Descpription = book.Descpription,
                Price = book.Price,
                ReleaseDate = book.ReleaseDate.Date.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                Copies = book.Copies,
                Categories = book.Categories.Select(c => c.Name).ToList(),
                Edition = book.Edition.ToString(),
                Author = book.Author.Firstname + " " + book.Author.LastName
            };

            return this.Ok(returnValue);
        }

        public IHttpActionResult GetFirstTenBooksWithGivenSubstring([FromUri] string word)
        {
            var context = new BookShopContext();

            var books = context.Books
                .Where(b => b.Title.Contains(word))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .Take(10)
                .ToList();
                
            if (books == null || books.Count < 1)
                return this.BadRequest("Books does not exist.");

            return this.Ok(books);
        }
    }
}
