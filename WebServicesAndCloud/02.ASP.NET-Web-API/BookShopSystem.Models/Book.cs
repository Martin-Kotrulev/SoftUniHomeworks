using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public Book ()
        {
            this.Categories = new HashSet<Category>();
        }

        [Key]
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Descpription { get; set; }

        public decimal Price { get; set; }

        public int Copies { get; set; }

        public Edition Edition { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
