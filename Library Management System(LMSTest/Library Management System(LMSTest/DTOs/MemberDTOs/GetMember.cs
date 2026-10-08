using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.DTOs.MemberDTOs
{
    public class GetMember
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
