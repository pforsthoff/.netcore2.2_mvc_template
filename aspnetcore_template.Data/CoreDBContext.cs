using aspnetcore_template.ServiceModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_template.Data
{
    public class CoreDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public CoreDbContext()
        {

        }
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
    : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
