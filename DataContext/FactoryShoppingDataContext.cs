using DataAccessLayer.FactoryShoppingModel;
using FactoryShopping.Models.FactoryShoppingModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataContext
{
    public class FactoryShoppingDataContext: DbContext
    {
        public FactoryShoppingDataContext() { }
        public FactoryShoppingDataContext(DbContextOptions options) : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //   optionsBuilder.UseSqlServer(@"Server=XIPL9397\SQLEXPRESS;Database=Vela_Engineer;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Cart> Carts { get; set; }
       // public DbSet<OrderDetails> orderDetail { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Address_Checkout> Addresses { get; set; }
    }
}
