using Microsoft.EntityFrameworkCore;

namespace Library_Management_System_LMSTest.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt):base(opt) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(u => u.borrowings).WithOne(u => u.Book).HasForeignKey(u => u.BookId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Member>().HasMany(u => u.borrowings).WithOne(u => u.Member).HasForeignKey(u => u.MemberId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>().HasMany(u => u.Books).WithOne(u => u.Category).HasForeignKey(u => u.CategoryId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Programming",
                Description = "Programming and software development books"
            },
            new Category
            {
                Id = 2,
                Name = "Database",
                Description = "Database and data management books"
            }
        );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "C++ Basics",
                    Author = "John Smith",
                    ISBN = "ISBN001",
                    Price = 450m,
                    IsAvailable = true,CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "SQL Fundamentals",
                    Author = "Sarah Ali",
                    ISBN = "ISBN002",
                    Price = 500m,
                    IsAvailable = false,CategoryId = 2
                }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    Name = "Ahmed Hassan",
                    Email = "ahmed@example.com",
                    PhoneNumber = "01012345678"
                },
                new Member
                {
                    Id = 2,
                    Name = "Sara Mohamed",
                    Email = "sara@example.com",
                    PhoneNumber = "01198765432"
                }
            );

            modelBuilder.Entity<Borrowing>().HasData(
                new Borrowing
                {
                    Id = 1,
                    BorrowDate = new DateTime(2026, 9, 20),
                    ReturnDate = new DateTime(2026, 9, 25),BookId = 1, MemberId = 1
                },
                new Borrowing
                {
                    Id = 2,
                    BorrowDate = new DateTime(2026, 9, 22),
                    ReturnDate = null,BookId = 2, MemberId = 2
                }
            );

        }




    }
}
