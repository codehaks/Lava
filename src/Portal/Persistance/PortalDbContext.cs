using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portal.Domain.Entities;
using Portal.Identity;
using Portal.Persistance.Configs;

namespace Portal.Persistance
{
    public class PortalDbContext : IdentityDbContext<ApplicationUser>
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
                : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<Payment> Payments { get; set; }

        public override int SaveChanges()
        {

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.UseHiLo("HiLoSeq");
            builder.ApplyConfiguration(new FoodConfig());
            builder.ApplyConfiguration(new OrderConfig());
            base.OnModelCreating(builder);
        }
    }
}
