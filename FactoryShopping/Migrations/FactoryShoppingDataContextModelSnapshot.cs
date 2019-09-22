﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FactoryShopping.Migrations
{
    [DbContext(typeof(FactoryShoppingDataContext))]
    partial class FactoryShoppingDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdMobile");

                    b.Property<string>("AdName");

                    b.Property<string>("AddressTypeID");

                    b.Property<string>("AlternetAdMobile");

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<int>("ZipCode");

                    b.HasKey("AddressId");

                    b.HasIndex("AddressTypeID");

                    b.ToTable("address");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.AddressType", b =>
                {
                    b.Property<string>("AddressTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("AddressTypeID");

                    b.ToTable("addressType");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CartDate");

                    b.Property<int>("OrderQuantity");

                    b.Property<int>("PId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId");

                    b.HasKey("CartId");

                    b.HasIndex("PId");

                    b.HasIndex("UserId");

                    b.ToTable("cart");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeedbackReport");

                    b.Property<int>("PId");

                    b.Property<int>("UserId");

                    b.HasKey("FeedbackId");

                    b.HasIndex("PId");

                    b.HasIndex("UserId");

                    b.ToTable("feedback");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<int>("CartId");

                    b.Property<string>("PaymentMode");

                    b.Property<DateTime>("orderDate");

                    b.HasKey("OrderId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CartId");

                    b.ToTable("orderDetail");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Product", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity");

                    b.HasKey("PId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Profile_Image");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Wishlist", b =>
                {
                    b.Property<int>("WishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("WishDate");

                    b.Property<int>("WishQuantity");

                    b.HasKey("WishId");

                    b.HasIndex("PId");

                    b.HasIndex("UserId");

                    b.ToTable("wishlist");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Address", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.AddressType", "addressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeID");
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Cart", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Product", "Products")
                        .WithMany()
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.FactoryShoppingModel.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Feedback", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Product", "Products")
                        .WithMany()
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.FactoryShoppingModel.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.OrderDetails", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Address", "address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Product", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Category", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.User", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.FactoryShoppingModel.Wishlist", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.Product", "Products")
                        .WithMany()
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.FactoryShoppingModel.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
