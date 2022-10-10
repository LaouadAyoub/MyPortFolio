using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Host = ec2-54-75-26-218.eu-west-1.compute.amazonaws.com; Port = 5432; user Id= mzpzuxcyrrnfer; Password = f907f8937231868374feb238c4eed88bd569bc08a16f6c56a5510c16199a2c4b; Database = dbca8euvjcqje3; URI = postgres://mzpzuxcyrrnfer:f907f8937231868374feb238c4eed88bd569bc08a16f6c56a5510c16199a2c4b@ec2-54-75-26-218.eu-west-1.compute.amazonaws.com:5432/dbca8euvjcqje3; Heroku CLI = heroku pg:psql postgresql-shaped-90811 --app portfolioayoub ");

            return new DataContext(optionsBuilder.Options);
        }
    }
}