using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Contexts.UserContex
{
    public class UserContex : DbContext
    {
        public UserContex(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=DESKTOP-9PPD55B ; initial catalog=UserDB;");
        }
    }
}