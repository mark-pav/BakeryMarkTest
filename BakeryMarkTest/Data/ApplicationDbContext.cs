using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryMarkTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BakeryMarkTest.Models.MenuItem> MenuItem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");

            builder.Entity<IdentityUser>(entity => { entity.ToTable(name: "User"); });
            builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Role"); });
            builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable(name: "UserRoles"); });
            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable(name: "UserClaims"); });
            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable(name: "Userlogins"); });
            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable(name: "RoleClaims"); });
            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable(name: "RoleClaims"); });
            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable(name: "UserTokens"); });
        }

    }
}
