using BookShopSystem.Data;
using BookShopSystem.Models;
using BookShopSystem.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookShopSystem.Services.Controllers
{
    /*
     GET
    /api/authors/{id}
    Gets author with id, first name, last name and a list of all his/her book titles.
    POST
    /api/authors
    Creates a new author with first name and last name (mandatory).
    GET
    /api/authors/{id}/books
    Gets books from author by id. Returns all data about the book + category names. */

    [RoutePrefix("api/authors")]
    public class AuthorsController : ApiController
    {
        [Route("{Id}")]
        public IHttpActionResult GetAuthorById(int id)
        {
            var context = new BookShopContext();
            var author = context.Authors.Find(id);
            if (author == null)
                return this.BadRequest("Author does not exist.");

            return this.Ok(new AuthorViewModel()
            {
                Author = author.Firstname + " " + author.LastName,
                Books = author.Books.Select(b => b.Title).ToList()
            });
        }

        public IHttpActionResult PostNewAuthor([FromUri]AuthorBindingModel author)
        {
            if (!this.ModelState.IsValid)
                return this.BadRequest("Last name is required");

            var newAuthor = new Author()
            {
                Firstname = author.FirstName,
                LastName = author.LastName
            };

            var context = new BookShopContext();
            context.Authors.Add(newAuthor);
            context.SaveChanges();
            return this.Ok("Author added.");
        }

        [Route("{id}/books")]
        public IHttpActionResult GetAuthorBooks(int id)
        {
            var context = new BookShopContext();
            var author = context.Authors.Find(id);

            if (author == null)
                return this.BadRequest("Author does not exist.");
            return this.Ok(author.Books.Select(b => b.Title).ToList());
        }
    }
}
