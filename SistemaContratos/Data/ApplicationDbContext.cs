using Microsoft.EntityFrameworkCore;
using SistemaContratos.Models;

namespace SistemaContratos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Area> area { get; set; }
        public DbSet<Contrato> contrato { get; set; }
        public DbSet<Leyenda> leyenda { get; set; }
        public DbSet<Persona> persona { get; set; }
        public DbSet<Usuario> usuario { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
