using System.ComponentModel.DataAnnotations.Schema;
using WebApplication12.Enum;

namespace WebApplication12.Data.Entity
{
    public class Animals
    {
        public int Id { get; set; }
        public AnimalsTypeEnum AnimalType { get; set; }
        public string Name { get; set; }
        [ForeignKey("familyMember")]
        public int FamilymemberId { get; set; }
        public FamilyMember familyMember { get; set; }

    }
}
