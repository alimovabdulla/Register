using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Register.Entities;

namespace Register.DataBase
{
    public class ClassContext:IdentityDbContext
    {
         
        public ClassContext(DbContextOptions<ClassContext> options):base(options) 
        {
            
        }




        public DbSet<AppUser> Users { get; set; }   

    }
}
