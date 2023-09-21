using Microsoft.EntityFrameworkCore;
using WebApplication222.Entites;

namespace WebApplication222
{
    public class FamilyDbContext:DbContext
    {
       public FamilyDbContext(DbContextOptions<FamilyDbContext> opt):base(opt) { }
        DbSet<Animal> Animals { get; set; }
        DbSet<Family> Families { get; set; }
        DbSet<Person> Persons { get; set; }
        
    }
}
