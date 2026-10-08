using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.DTOs.BookDTOs
{
    public class GetAllBooks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]

        public string ISBN { get; set; }
        [Required, Range(0.1, int.MaxValue)]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
