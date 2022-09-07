using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id = Guid.NewGuid(),
                    Avatar = "pdp.jfif",
                    FullName = "Ayoub LAOUAD",
                    Profil = "Backend developer",
                    Address = new Address() 
                    { Id = Guid.NewGuid(), City = "Antwerp", Street = "Kruikstraat", Number=1 }
                }
                );
        }

        public DbSet<Owner> Owner { get; set; }
<<<<<<< HEAD
        public DbSet<PortFolioItem> PortFolioItems { get; set; }

=======
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
>>>>>>> fe2f1836cc52df00a128aec106b8c08fb5b3387c
    }
}