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
//on model creating
/*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            Owner[] owners = new Owner[] {             
            new Owner()
            {
                Id = Guid.NewGuid(),
                Avatar = "pdp.jfif",
                FullName = "Ayoub LAOUAD",
                Profil = "Backend developer"
            }};

            modelBuilder.Entity<Owner>().HasData(owners);

        }
*/




        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortfolioItem> PortFolioItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "workstation id=myportfolioDb001.mssql.somee.com;packet size=4096;user id=Ayoub_SQLLogin_1;pwd=6w8xggmsnm;data source=myportfolioDb001.mssql.somee.com;persist security info=False;initial catalog=myportfolioDb001";
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}