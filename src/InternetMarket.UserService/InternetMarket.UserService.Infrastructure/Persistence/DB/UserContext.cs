using InternetMarket.UserService.Domain;
using Microsoft.EntityFrameworkCore;

namespace InternetMarket.UserService.Infrastructure.Persistence.DB
{
    public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}