using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required , EmailAddress ]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }


        public ICollection<Borrowing> borrowings { get; set; } = new List<Borrowing>();
    }
}
