using Library_Management_System_LMSTest.DTOs.CategoryDTOs;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Library_Management_System_LMSTest.AllCustoms.CategoryCustoms
{
    public class CategoryRepo : GenaricRepos<Category> , ICategoryRepo
    {
        private readonly Context context;
        public CategoryRepo(Context c) : base(c)
        {
            
            context = c;
        }

        public bool DeleteCategory(int id)
        {
            var category = context.Categories
                    .Include(c => c.Books)
                    .FirstOrDefault(c => c.Id == id);

            if (category == null || category.Books.Any())
            {
                return false;
            }
            Delete(category);
            return true;
        }


        public List<GetAllCategoryWithBokName> GetCategory()
        {
            return context.Categories.Select(x => new GetAllCategoryWithBokName
            {
                Name = x.Name,
                BookCount = x.Books.Count(),
            }).ToList();
        }
    }
}
