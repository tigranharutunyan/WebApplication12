using WebApplication12.Data.Entity;

namespace WebApplication12.Data.Repository.Interfaces
{
    public interface IFamilyMemberRepository
    {
        void Add(FamilyMember member);
        List<FamilyMember> GetAll();    
        FamilyMember Get(int id);   
        void Delete(int id);
        void SaveChanges();

    }
}
