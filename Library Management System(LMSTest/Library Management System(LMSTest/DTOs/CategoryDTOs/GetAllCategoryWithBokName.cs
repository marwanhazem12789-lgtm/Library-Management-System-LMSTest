using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_LMSTest.DTOs.CategoryDTOs
{
    public class GetAllCategoryWithBokName
    {
        [Required]
        public string Name { get; set; }
        public int BookCount { get; set; }

    }
}
