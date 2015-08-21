namespace BookShopSystem.Data
{
    using Migrations;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookShopContext : DbContext
    {
        public BookShopContext()
            : base("BookShopContext")
        {
            var migrationStrategy =
                new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
        }

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
    }
}