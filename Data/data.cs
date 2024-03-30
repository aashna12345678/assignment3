using Microsoft.EntityFrameworkCore;
using assignment3.Models;

namespace A3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
