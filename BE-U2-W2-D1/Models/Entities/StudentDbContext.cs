using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace BE_U2_W2_D1.Models.Entities
{
    public class StudentDbContext : DbContext

    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        { 
        }

        public DbSet<Student> Students { get; set; }
    }
}
