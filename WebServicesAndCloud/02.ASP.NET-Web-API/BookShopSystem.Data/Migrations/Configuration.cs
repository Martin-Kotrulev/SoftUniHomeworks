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

        }

        private void SeedCategories(BookShopContext context)
        {

        }

        private void SeedBooks(BookShopContext context)
        {
            var random = new Random();
            var authors = File.ReadAllLines("../../../authors.txt");
            var categories = File.ReadAllLines("../../../categories.txt");
            using (var reader = new StreamReader("../../../books.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    // Manage author
                    var authorIndex = random.Next(1, authors.Length);
                    var authorName = authors[authorIndex].Split(' ');
                    var author = new Author()
                    {
                        Firstname = authorName[0],
                        LastName = authorName[1]
                    };

                    // Manage book
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

                    // Manage category
                    var categoryIndex = random.Next(0, categories.Length);
                    var category = new Category() { Name = categories[categoryIndex] };
                    book.Categories.Add(category);

                    context.Books.Add(book);

                    line = reader.ReadLine();
                }
            }
        }

        protected override void Seed(BookShopContext context)
        {
          
            if (context.Books.Count() == 0)
            {
                SeedAuthors();
                SeedCategories();
                SeedBooks(context);
            }
            
        }
    }
}
