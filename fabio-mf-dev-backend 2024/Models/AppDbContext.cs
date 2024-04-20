using Microsoft.EntityFrameworkCore;

namespace fabio_mf_dev_backend_2024.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
