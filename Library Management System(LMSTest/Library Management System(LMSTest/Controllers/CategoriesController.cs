using Library_Management_System_LMSTest.Models;
using Library_Management_System_LMSTest.Unit_Of_Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_LMSTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
       public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public IActionResult Create(DTOs.CategoryDTOs.CreateCategory dto)
        {
            if(ModelState.IsValid ==  false)
            {
                return BadRequest(ModelState);
            }
            var t = new Category
            {
                Description = dto.Description,
                Name = dto.Name,

            };_unitOfWork.Category.Add(t);
            _unitOfWork.Save();
            return Created("",t);
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var t = _unitOfWork.Category.GetCategory();
            return Ok(t);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var e = _unitOfWork.Category.DeleteCategory(id);
            if(e == false)
            {
                return BadRequest(ModelState);
            }
            _unitOfWork.Save();

            return NoContent();
        }


    }
}
