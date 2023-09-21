using System.Runtime.CompilerServices;
using WebApplication12.Enum;

namespace WebApplication12.Data.Entity
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public PersonTypeEnum PersonType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public GenderTypeEnum GenderType { get; set; }
        public ICollection<Animals> Animals { get; set; }


    }
}
