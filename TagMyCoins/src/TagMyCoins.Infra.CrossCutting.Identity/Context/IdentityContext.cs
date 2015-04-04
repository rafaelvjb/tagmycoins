using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace TagMyCoins.Infra.CrossCutting.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("TagMyCoins", throwIfV1Schema: false)
        {
        }

        public IDbSet<Client> Client { get; set; }

        public IDbSet<Claims> Claims { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .ToTable("AspNetUsers")
                .Property(p => p.Id)
                .HasColumnName("UserId");

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("AspNetUsers")
                .Property(p => p.Id)
                .HasColumnName("UserId");

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasRequired(a => a.User)
            //    .WithRequiredPrincipal(a => a.UserId);
        }
    }
}
