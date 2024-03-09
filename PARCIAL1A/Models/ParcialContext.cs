using Microsoft.EntityFrameworkCore;

namespace PARCIAL1A.Models
{
    public class ParcialContext : DbContext
    {
        public ParcialContext(DbContextOptions<ParcialContext> options) : base(options)
        {

        }

        public DbSet<autores> Autores { get; set; }
        public DbSet<autorlibro> AutorLibro { get; set; }
        public DbSet<posts> Posts { get; set; }
        public DbSet<libros> Libros { get; set; }
    }
}
