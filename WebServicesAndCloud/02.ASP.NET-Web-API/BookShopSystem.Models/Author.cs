namespace BookShopSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Firstname { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
