using System;
using System.ComponentModel.DataAnnotations;

namespace BookCatalogue.Model
{
    public class BookItemModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Title { get; set; }

        public string Author { get; set; }

        [MaxLength(13), MinLength(13)]
        public string ISBN { get; set; }
        public string PublicationDate { get; set; }
    }
}
