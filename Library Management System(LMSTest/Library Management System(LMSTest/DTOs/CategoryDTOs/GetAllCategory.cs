using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.DTOs.CategoryDTOs
{
    public class GetAllCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
    }
}
