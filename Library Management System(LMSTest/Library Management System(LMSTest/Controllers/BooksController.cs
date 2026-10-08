using Library_Management_System_LMSTest.DTOs.BookDTOs;
using Library_Management_System_LMSTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace Library_Management_System_LMSTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly Unit_Of_Work.IUnitOfWork _unitOfWork;
        public BooksController(Unit_Of_Work.IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet("Serach")]
        public IActionResult GetBySearxch(string Word)
        {
            var t = _unitOfWork.Book.Search(Word);
            return Ok(t);
        }

        [HttpGet("highest Price")]
        public IActionResult GetHeigh()
        {
            var t = _unitOfWork.Book.highest_Price();
            return Ok(t);
        }


        [HttpPost]
        public IActionResult Post(CreateBook c)
        {
            var t = _unitOfWork.Book.CreateBook(c);

            if(t == false)
            {
                return BadRequest();
            }
            var r = new Book
            {
                Author = c.Author,
                CategoryId = c.CategoryId,
                ISBN = c.ISBN,
                IsAvailable = c.IsAvailable,
                Price = c.Price,
                Title = c.Title,

            };
            _unitOfWork.Book.Add(r);
            _unitOfWork.Save();
            return Created("",r);
        }
    }
}
