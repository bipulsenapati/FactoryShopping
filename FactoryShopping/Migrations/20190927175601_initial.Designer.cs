﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FactoryShopping.Migrations
{
    [DbContext(typeof(FactoryShoppingDataContext))]
    [Migration("20190927175601_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("CartDate");

                    b.Property<decimal>("CartTotal")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("OrderQuantity");

                    b.Property<int>("PId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName");

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

            modelBuilder.Entity("FactoryShopping.Models.FactoryShoppingModel.Address_Checkout", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdMobile");

                    b.Property<string>("AdName");

                    b.Property<string>("AddressTypeID");

                    b.Property<string>("City");

                    b.Property<int>("State");

                    b.Property<string>("Street");

                    b.Property<int>("UserId");

                    b.Property<int>("ZipCode");

                    b.HasKey("AddressId");

                    b.HasIndex("AddressTypeID");

                    b.HasIndex("UserId");

                    b.ToTable("addresses");
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

            modelBuilder.Entity("FactoryShopping.Models.FactoryShoppingModel.Address_Checkout", b =>
                {
                    b.HasOne("DataAccessLayer.FactoryShoppingModel.AddressType", "addressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeID");

                    b.HasOne("DataAccessLayer.FactoryShoppingModel.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
