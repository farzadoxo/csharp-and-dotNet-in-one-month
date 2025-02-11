using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MyWebAPI.Models;

namespace MyWebAPI.Contexs
{
    public class UserContex : IdentityDbContext
    {
        public UserContex(DbContextOptions option):base(option)
        {

        }

        public DbSet<User> Userss { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9PPD55B;Initial Catalog=UserDb;integrated security=true;TrustServerCertificate=True");
        }
    }
}