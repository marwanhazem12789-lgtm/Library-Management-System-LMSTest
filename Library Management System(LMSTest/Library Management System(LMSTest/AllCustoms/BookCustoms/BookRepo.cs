using Library_Management_System_LMSTest.DTOs.BookDTOs;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;

namespace Library_Management_System_LMSTest.AllCustoms.BookCustoms
{
    public class BookRepo : GenaricRepos<Book>, IBookRepo
    {
        private readonly Context _conext;
        public BookRepo(Context context) : base(context)
        {
            this._conext = context;

        }

        public bool CreateBook(CreateBook book)
        {
            return _conext.Books.Where(i => i.CategoryId  == book.CategoryId).Any();
        }

        public List<GetAllBooks> highest_Price()
        {
          return  _conext.Books.OrderByDescending(x => x.Price).Select(o =>new GetAllBooks
          {
              Author = o.Author,
             IsAvailable = o.IsAvailable,
                ISBN = o.ISBN,
                Price = o.Price,
                Title = o.Title,
                Id = o.Id
          }).ToList();
        }

        public List<GetAllBooks> Search(string Key)
        {
            return _conext.Books.Where(i => i.Title.Contains(Key) || i.Author.Contains(Key)).Select(n => new GetAllBooks
            {
                Id = n.Id,
                Title = n.Title,
                Price = n.Price,
                Author = n.Author,
            }).ToList();
        }
    }
}
