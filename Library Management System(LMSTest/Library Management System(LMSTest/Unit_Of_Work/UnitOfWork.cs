using Library_Management_System_LMSTest.AllCustoms.BookCustoms;
using Library_Management_System_LMSTest.AllCustoms.CategoryCustoms;
using Library_Management_System_LMSTest.AllCustoms.MemberCustom;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;
using Library_Management_System_LMSTest.Unit_Of_Work;
using Microsoft.EntityFrameworkCore;

namespace Library_Management_System_LMSTest.Unit_Of_Work
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public IBookRepo Book { get; }

        public ICategoryRepo Category { get; }

        public IGenaricRepo<Borrowing> Borrowing { get; }

        public IMemberRepo Member { get; }
        public UnitOfWork(Context context, IMemberRepo m, IBookRepo b, IGenaricRepo<Borrowing> br, ICategoryRepo ct)
        {
            this._context = context;
            this.Book = b;
            this.Member = m;
            this.Borrowing = br;
            this.Category = ct;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}