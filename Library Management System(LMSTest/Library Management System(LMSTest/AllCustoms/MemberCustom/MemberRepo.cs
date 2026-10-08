using Library_Management_System_LMSTest.DTOs.MemberDTOs;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;

namespace Library_Management_System_LMSTest.AllCustoms.MemberCustom
{
    public class MemberRepo : GenaricRepos<Member> , IMemberRepo
    {
        private readonly Context _context;
        public MemberRepo(Context c) : base(c) 
        {
            _context = c;
        }

        public GetMemberState Getallstates(int id)
        {
            var s = _context.Members.Where(o => o.Id == id).Select(m => new GetMemberState
            {
                MemberName = m.Name,

                TotalBorrowedBooks = m.borrowings.Count(),

                ReturnedBooks = m.borrowings.Count(b => b.ReturnDate != null),

                CurrentlyBorrowedBooks = m.borrowings.Count(b => b.ReturnDate == null)
            }).FirstOrDefault();

            return s;
        }

        public List<TopReaderDto> GetTopReaders()
        {
            return _context.Members
        .OrderByDescending(m => m.borrowings.Count())
        .Take(5)
        .Select(m => new TopReaderDto
        {
            Id = m.Id,
            FullName = m.Name,
            Email = m.Email,
            BorrowedBooksCount = m.borrowings.Count()
        }).ToList();
        }
    }
}
