using Library_Management_System_LMSTest.DTOs.BookDTOs;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Library_Management_System_LMSTest.AllCustoms.BookCustoms
{
    public interface IBookRepo : IGenaricRepo<Models.Book>
    {
        public bool CreateBook(CreateBook book);
        public List<DTOs.BookDTOs.GetAllBooks> Search(string Key);
        public List<DTOs.BookDTOs.GetAllBooks> highest_Price();
    }
}
