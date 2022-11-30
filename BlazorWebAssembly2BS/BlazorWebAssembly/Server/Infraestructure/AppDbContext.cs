using Microsoft.EntityFrameworkCore;
using BlazorWebAssembly.Server.Domain.Users;
using BlazorWebAssembly.Server.Domain.UserAccounts;
using BlazorWebAssembly.Server.Infraestructure.Users;
using BlazorWebAssembly.Server.Infraestructure.UserAccounts;

namespace BlazorWebAssembly.Server.Infraestructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountEntityTypeConfiguration());
            //modelBuilder.Entity<User>().HasData(new User(new Guid("bc255ce5-a27d-42e0-b287-248e98c2d093"),new Username("admin"),new Password("admin")));
            //modelBuilder.Entity<UserAccount>().HasData(new UserAccount(new Guid("b2355ce5-a27d-42e0-b287-248e98c2d093"), new Username("admin"), new Password("admin"),new Role("Administrator")));
        }
    }
}
