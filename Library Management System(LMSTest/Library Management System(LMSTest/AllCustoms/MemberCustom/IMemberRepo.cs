using Library_Management_System_LMSTest.DTOs.MemberDTOs;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;

namespace Library_Management_System_LMSTest.AllCustoms.MemberCustom
{
    public interface IMemberRepo : IGenaricRepo<Member>
    {
        GetMemberState Getallstates(int id);
        List<TopReaderDto> GetTopReaders();
    }
}
