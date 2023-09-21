using Microsoft.EntityFrameworkCore;
using WebApplication12.Data.Entity;

namespace WebApplication12.Data
{
    public class MyContext:DbContext 
    {
        public MyContext(DbContextOptions dbContextOptions ) : base( dbContextOptions )
        {

        }
        DbSet<FamilyMember> FamilyMembers { get; set; }
        DbSet<Animals> Animals { get; set; }    
    }
}
