using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;

namespace Library_Management_System_LMSTest.AllCustoms.CategoryCustoms
{
    public interface ICategoryRepo : IGenaricRepo<Category>
    {
        List<DTOs.CategoryDTOs.GetAllCategoryWithBokName> GetCategory();
        bool DeleteCategory(int id);
    }
}
