using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValue("NEWID");
            modelBuilder.Entity<PortFolioItem>().Property(x => x.Id).HasDefaultValue("NEWID");



            modelBuilder.Entity<Owner>().HasData
            (
                new Owner()
                {
                    Id = Guid.NewGuid(),
                    _Avatar = "pdp.jfif",
                    _FullName = "Ayoub LAOUAD",
                    _Profil = "Backend Developer"
                }

            );
        }

        public DbSet<Owner> Owner { get; set; }S
        public DbSet<PortFolioItem> PortFolioItems { get; set; }

    }
}
