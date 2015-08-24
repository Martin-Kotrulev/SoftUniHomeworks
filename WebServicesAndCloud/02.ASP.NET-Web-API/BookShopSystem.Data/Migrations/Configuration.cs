namespace BookShopSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        private void SeedAuthors(BookShopContext context)
        {
            var authors = File.ReadAllLines("../../../authors.txt");
            foreach (var a in authors)
            {
                var authorName = a.Split(' ');
                var author = new Author()
                {
                    Firstname = authorName[0],
                    LastName = authorName[1]
                };
                context.Authors.Add(author);
            }
            context.SaveChanges();
        }

        private void SeedCategories(BookShopContext context)
        {
            var categories = File.ReadAllLines("../../../categories.txt");
            foreach (var c in categories)
            {
                context.Categories.Add(new Category() {Name = c});
            }
            context.SaveChanges();
        }

        private void SeedBooks(BookShopContext context)
        {
            var random = new Random();
            
            using (var reader = new StreamReader("../../../books.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {          
                    var data = line.Split(new[] { ' ' }, 6);
                    var edition = (Edition)int.Parse(data[0]); 
                    var releaseDate = DateTime.ParseExact(
                        data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                    var copies = int.Parse(data[2]);
                    var price = decimal.Parse(data[3]);
                    var title = data[5];
                    var book = new Book()
                    {
                        Edition = edition,
                        ReleaseDate = releaseDate,
                        Copies = copies,
                        Price = price,
                        Title = title
                    };

                    var categoriesCount = context.Categories.Count();
                    var category = context.Categories.Find(random.Next(1, categoriesCount + 1)); 
                    var authorsCount = context.Authors.Count();
                    var authorId = random.Next(1, authorsCount + 1);
                    book.Categories.Add(category);
                    book.AuthorId = authorId;

                    context.Books.Add(book);

                    line = reader.ReadLine();
                }
            }
        }

        protected override void Seed(BookShopContext context)
        {
          
            if (context.Books.Count() == 0)
            {
                SeedAuthors(context);
                SeedCategories(context);
                SeedBooks(context);
            }           
        }
    }
}
