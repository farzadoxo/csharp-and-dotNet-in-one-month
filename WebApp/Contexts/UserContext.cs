using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Contexts.UserContext
{
    public class UserContextt : DbContext
    {
        public UserContextt(DbContextOptions option):base(option)
        {

        }

        public DbSet<User> DBSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source= ; initialize catalog= ; integrated security= true");
        }
    }
}