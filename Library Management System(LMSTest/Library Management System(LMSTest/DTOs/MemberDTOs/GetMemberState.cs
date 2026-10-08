namespace Library_Management_System_LMSTest.DTOs.MemberDTOs
{
    public class GetMemberState
    {
        public string MemberName { get; set; }
        public int TotalBorrowedBooks { get; set; }
        public int ReturnedBooks { get; set; }
        public int CurrentlyBorrowedBooks { get; set; }
    }
}
