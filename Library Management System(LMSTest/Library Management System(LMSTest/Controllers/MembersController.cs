using Library_Management_System_LMSTest.Models;
using Library_Management_System_LMSTest.Unit_Of_Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_LMSTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MembersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public IActionResult Create(DTOs.MemberDTOs.CreateMember dto)
        {
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            var t = new Member
            {
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
            };
            _unitOfWork.Member.Add(t);
            _unitOfWork.Save();
            return Created("", t);
        }

        [HttpGet("Top_Readers")]
        public IActionResult Getall()
        {
            var t = _unitOfWork.Member.GetTopReaders();
            return Ok(t);
        }
        [HttpGet("Sates/{id}")]
        public IActionResult Getall(int id)
        {
            var t = _unitOfWork.Member.Getallstates(id);
            return Ok(t);
        }

    }
}
