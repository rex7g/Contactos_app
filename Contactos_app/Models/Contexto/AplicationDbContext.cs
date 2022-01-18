using Microsoft.EntityFrameworkCore;

namespace Contactos_app.Models.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Contacto> Contactos { get; set; }
    }
}
