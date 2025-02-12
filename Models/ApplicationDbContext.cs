using Microsoft.EntityFrameworkCore;
namespace UserCRUD.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
      
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
