using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models
{
    public class Book
    {
        //[Key]
        public int BookId { get; set; } //If the name is Id or ends with Id and there is no key defined, it will be considered as primary key
        public string Title { get; set; }

        [MaxLength(20)] //Allowed max length of column
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped] //This column will not be created in db 
        public string PriceRange { get; set; }

        // One to one relation -> Parent Class
        public BookDetail BookDetail { get; set; }

        // One to many relation -> Child Class
        [ForeignKey(nameof(Publisher))]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }

        // Many to many relation
        public List<BookAuthorMap> BookAuthorMap { get; set; }

    }
}
