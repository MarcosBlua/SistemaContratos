using Microsoft.EntityFrameworkCore;
using SistemaContratos.Models;

namespace SistemaContratos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AreaViewModel> area { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
