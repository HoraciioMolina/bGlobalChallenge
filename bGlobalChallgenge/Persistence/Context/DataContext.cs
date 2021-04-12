using bGlobalChallgenge.Models.Entities;
using bGlobalChallgenge.Models.MetaData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace bGlobalChallgenge.Persistence.Context
{
    public class DataContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration["ConnectionString"]);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Vehicle>(new VehicleMetaData());
            modelBuilder.ApplyConfiguration<Brand>(new BrandMetaData());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
