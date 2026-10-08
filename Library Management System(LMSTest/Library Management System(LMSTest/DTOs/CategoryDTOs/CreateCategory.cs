using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.DTOs.CategoryDTOs
{
    public class CreateCategory
    {
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
    }
}
