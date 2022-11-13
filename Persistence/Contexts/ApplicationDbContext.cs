using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Intercepter;


namespace Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly EntitySaveChangesInterceptor _entitySaveChangesInterceptor;
        public ApplicationDbContext(DbContextOptions options, EntitySaveChangesInterceptor entitySaveChangesInterceptor) : base(options)
        {
            _entitySaveChangesInterceptor = entitySaveChangesInterceptor;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_entitySaveChangesInterceptor);
        }
    }
    
}
