using Library_Management_System_LMSTest.AllCustoms.BookCustoms;
using Library_Management_System_LMSTest.AllCustoms.CategoryCustoms;
using Library_Management_System_LMSTest.AllCustoms.MemberCustom;
using Library_Management_System_LMSTest.GenaricRepo;

namespace Library_Management_System_LMSTest.Unit_Of_Work
{
    public interface IUnitOfWork
    {
        int Save ();
        IBookRepo Book { get; }
        ICategoryRepo Category { get; }
        IGenaricRepo<Models.Borrowing> Borrowing { get; }
        IMemberRepo Member { get; }



    }
}
