using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortfolioItem> PortFolioItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "workstation id=myportfolioDb001.mssql.somee.com;packet size=4096;user id=Ayoub_SQLLogin_1;pwd=6w8xggmsnm;data source=myportfolioDb001.mssql.somee.com;persist security info=False;initial catalog=myportfolioDb001; TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connectionString);
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        //on model creating
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

            //IdentityUser identityUser = new IdentityUser()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    UserName = "admin@gmail.com",
            //    NormalizedUserName = "ADMIN@GMAIL.COM",
            //    Email = "admin@gmail.com",
            //    NormalizedEmail = "ADMIN@GMAIL.COM",
            //    PasswordHash = "Admin@123456",
            //    PhoneNumber = null,
            //    PhoneNumberConfirmed = false,
            //    TwoFactorEnabled = false,
            //    LockoutEnd = null,
            //    LockoutEnabled = false,
            //    AccessFailedCount= 0
            //};

            modelBuilder.Entity<Owner>().HasData(owners);
            //modelBuilder.Entity<IdentityUser>().HasData(identityUser);

        }
    }
}