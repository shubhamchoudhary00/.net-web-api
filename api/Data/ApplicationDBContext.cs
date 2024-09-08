using Microsoft.EntityFrameworkCore;
using api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; } // Plural name for DbSet
        public DbSet<Comments> Comment { get; set; } // Plural name for DbSet
        public DbSet<Portfolio> Portfolios { get; set; } // Plural name for DbSet

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configuring the one-to-many relationship between Stock and Comments
            // modelBuilder.Entity<Comments>()
            //     .HasOne(c => c.Stock)
            //     .WithMany(s => s.CommentsList)
            //     .HasForeignKey(c => c.StockId)
            //     .OnDelete(DeleteBehavior.Cascade); // Optional: Defines cascade delete

            // base.OnModelCreating(modelBuilder);

            base.OnModelCreating(builder);

            builder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

            builder.Entity<Portfolio>()
            .HasOne(u => u.AppUser)
            .WithMany(u => u.Portfolios)
            .HasForeignKey(p => p.AppUserId);

            builder.Entity<Portfolio>()
            .HasOne(u => u.Stock)
            .WithMany(u => u.Portfolios)
            .HasForeignKey(p => p.StockId);



            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName="ADMIN",
                },
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="USER",
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
