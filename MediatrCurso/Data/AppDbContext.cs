using MediatrCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatrCurso.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> Usuarios { get; set; }
    }
}
