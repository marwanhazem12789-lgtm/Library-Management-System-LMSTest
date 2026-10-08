using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System_LMSTest.Models
{
    [Index (nameof(ISBN), IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]

        public string ISBN { get; set; }
        [Required , Range(0.1 , int.MaxValue)]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }


        public ICollection<Borrowing> borrowings { get; set; } = new List<Borrowing>();
    }
}
