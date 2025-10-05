using Microsoft.EntityFrameworkCore;
using MyFridgeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridgeApp.Data
{
    internal class Context : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyFridgeApp;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Item -> Category (every Item must belong to a Category, 
        //    // and a Category in use cannot be deleted)
        //    modelBuilder.Entity<Item>()
        //        .HasOne(i => i.Category)
        //        .WithMany()
        //        .HasForeignKey(i => i.CategoryId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    // Cart -> CartItems (deleting a Cart will also delete its CartItems)
        //    modelBuilder.Entity<Cart>()
        //        .HasMany(c => c.Items)
        //        .WithOne(ci => ci.Cart)
        //        .HasForeignKey(ci => ci.CartId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // CartItem -> Item (optional FK; if the inventory Item is removed, 
        //    // keep the CartItem history and set ItemId to null)
        //    modelBuilder.Entity<CartItem>()
        //        .HasOne(ci => ci.Item)
        //        .WithMany()
        //        .HasForeignKey(ci => ci.ItemId)
        //        .OnDelete(DeleteBehavior.SetNull);

        //    // Seed fixed Categories (user cannot change these)
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { Id = 1, Name = "Meat", Description = "All kinds of meat products" },
        //        new Category { Id = 2, Name = "Seafood", Description = "Fish, prawns, and other seafood" },
        //        new Category { Id = 3, Name = "Fruit", Description = "Fresh fruits" },
        //        new Category { Id = 4, Name = "Vegetable", Description = "Fresh vegetables" },
        //        new Category { Id = 5, Name = "Dairy", Description = "Milk, cheese, yogurt, and dairy products" },
        //        new Category { Id = 6, Name = "Eggs", Description = "All types of eggs" },
        //        new Category { Id = 7, Name = "Drinks", Description = "Juices, soft drinks, and other beverages" },
        //        new Category { Id = 8, Name = "Sauces", Description = "Sauces, condiments, and dressings" },
        //        new Category { Id = 9, Name = "Bakery", Description = "Bread, cakes, and other baked goods" },
        //        new Category { Id = 10, Name = "Other", Description = "Items not covered by other categories" }
        //    );
        //}

    }
}


