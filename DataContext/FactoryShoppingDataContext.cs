using DataAccessLayer.FactoryShoppingModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataContext
{
    public class FactoryShoppingDataContext: DbContext
    {
        public FactoryShoppingDataContext() { }
        public FactoryShoppingDataContext(DbContextOptions options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer(@"Server=XIPL9397\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
