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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Item -> Category (every Item must belong to a Category, 
            // and a Category in use cannot be deleted)
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Category)
                .WithMany()
                .HasForeignKey(i => i.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Cart -> CartItems (deleting a Cart will also delete its CartItems)
            modelBuilder.Entity<Cart>()
                .HasMany(c => c.Items)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // CartItem -> Item (optional FK; if the inventory Item is removed, 
            // keep the CartItem history and set ItemId to null)
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Item)
                .WithMany()
                .HasForeignKey(ci => ci.ItemId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed fixed Categories (user cannot change these)
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Meat", Description = "All kinds of meat products" },
                new Category { Id = 2, Name = "Seafood", Description = "Fish, prawns, and other seafood" },
                new Category { Id = 3, Name = "Fruit", Description = "Fresh fruits" },
                new Category { Id = 4, Name = "Vegetable", Description = "Fresh vegetables" },
                new Category { Id = 5, Name = "Dairy", Description = "Milk, cheese, yogurt, and dairy products" },
                new Category { Id = 6, Name = "Eggs", Description = "All types of eggs" },
                new Category { Id = 7, Name = "Drinks", Description = "Juices, soft drinks, and other beverages" },
                new Category { Id = 8, Name = "Sauces", Description = "Sauces, condiments, and dressings" },
                new Category { Id = 9, Name = "Bakery", Description = "Bread, cakes, and other baked goods" },
                new Category { Id = 10, Name = "Other", Description = "Items not covered by other categories" }
            );

            modelBuilder.Entity<Item>().HasData(
                // Meat
                new Item { Id = 1, Name = "Beef Steak", CategoryId = 1, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 7), Quantity = 2, Unit = "kg", Notes = "Grass-fed beef", Status = ItemStatus.Active },
                new Item { Id = 2, Name = "Pork Chops", CategoryId = 1, ImportDate = new DateTime(2025, 10, 2), ExpiryDate = new DateTime(2025, 10, 6), Quantity = 6, Unit = "pieces", Notes = "", Status = ItemStatus.Active },

                // Seafood
                new Item { Id = 3, Name = "Salmon Fillet", CategoryId = 2, ImportDate = new DateTime(2025, 9, 29), ExpiryDate = new DateTime(2025, 10, 5), Quantity = 1, Unit = "kg", Notes = "Fresh Atlantic salmon", Status = ItemStatus.Active },
                new Item { Id = 4, Name = "Prawns", CategoryId = 2, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 3), Quantity = 500, Unit = "g", Notes = "Frozen prawns", Status = ItemStatus.Active },

                // Fruit
                new Item { Id = 5, Name = "Apples", CategoryId = 3, ImportDate = new DateTime(2025, 9, 27), ExpiryDate = new DateTime(2025, 10, 7), Quantity = 6, Unit = "pieces", Notes = "", Status = ItemStatus.Active },
                new Item { Id = 6, Name = "Bananas", CategoryId = 3, ImportDate = new DateTime(2025, 9, 30), ExpiryDate = new DateTime(2025, 10, 3), Quantity = 4, Unit = "pieces", Notes = "Ripe", Status = ItemStatus.Active },
                new Item { Id = 7, Name = "Grapes", CategoryId = 3, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 8), Quantity = 1, Unit = "kg", Notes = "Seedless", Status = ItemStatus.Active },

                // Vegetable
                new Item { Id = 8, Name = "Carrots", CategoryId = 4, ImportDate = new DateTime(2025, 9, 29), ExpiryDate = new DateTime(2025, 10, 11), Quantity = 1, Unit = "kg", Notes = "", Status = ItemStatus.Active },
                new Item { Id = 9, Name = "Broccoli", CategoryId = 4, ImportDate = new DateTime(2025, 9, 30), ExpiryDate = new DateTime(2025, 10, 5), Quantity = 2, Unit = "pieces", Notes = "Organic", Status = ItemStatus.Active },

                // Dairy
                new Item { Id = 10, Name = "Milk", CategoryId = 5, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 7), Quantity = 2, Unit = "liters", Notes = "Low-fat", Status = ItemStatus.Active },
                new Item { Id = 11, Name = "Cheddar Cheese", CategoryId = 5, ImportDate = new DateTime(2025, 9, 28), ExpiryDate = new DateTime(2025, 10, 18), Quantity = 200, Unit = "g", Notes = "Block", Status = ItemStatus.Active },

                // Eggs
                new Item { Id = 12, Name = "Chicken Eggs", CategoryId = 6, ImportDate = new DateTime(2025, 9, 25), ExpiryDate = new DateTime(2025, 10, 7), Quantity = 12, Unit = "pieces", Notes = "Free-range", Status = ItemStatus.Active },
                new Item { Id = 13, Name = "Duck Eggs", CategoryId = 6, ImportDate = new DateTime(2025, 9, 30), ExpiryDate = new DateTime(2025, 10, 10), Quantity = 6, Unit = "pieces", Notes = "", Status = ItemStatus.Active },

                // Drinks
                new Item { Id = 14, Name = "Orange Juice", CategoryId = 7, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 8), Quantity = 1, Unit = "liter", Notes = "Freshly squeezed", Status = ItemStatus.Active },
                new Item { Id = 15, Name = "Coca-Cola", CategoryId = 7, ImportDate = new DateTime(2025, 9, 27), ExpiryDate = new DateTime(2026, 4, 6), Quantity = 6, Unit = "cans", Notes = "", Status = ItemStatus.Active },

                // Sauces
                new Item { Id = 16, Name = "Tomato Ketchup", CategoryId = 8, ImportDate = new DateTime(2025, 8, 6), ExpiryDate = new DateTime(2026, 8, 6), Quantity = 1, Unit = "bottle", Notes = "Big size", Status = ItemStatus.Active },
                new Item { Id = 17, Name = "Soy Sauce", CategoryId = 8, ImportDate = new DateTime(2025, 7, 7), ExpiryDate = new DateTime(2026, 1, 7), Quantity = 1, Unit = "bottle", Notes = "Japanese style", Status = ItemStatus.Active },

                // Bakery
                new Item { Id = 18, Name = "Whole Wheat Bread", CategoryId = 9, ImportDate = new DateTime(2025, 10, 1), ExpiryDate = new DateTime(2025, 10, 4), Quantity = 1, Unit = "loaf", Notes = "", Status = ItemStatus.Active },
                new Item { Id = 19, Name = "Chocolate Cake", CategoryId = 9, ImportDate = new DateTime(2025, 10, 3), ExpiryDate = new DateTime(2025, 10, 5), Quantity = 1, Unit = "piece", Notes = "Birthday cake", Status = ItemStatus.Active },

                // Other
                new Item { Id = 20, Name = "Butter", CategoryId = 10, ImportDate = new DateTime(2025, 9, 26), ExpiryDate = new DateTime(2025, 10, 16), Quantity = 250, Unit = "g", Notes = "Salted", Status = ItemStatus.Active },
                new Item { Id = 21, Name = "Pickles", CategoryId = 10, ImportDate = new DateTime(2025, 9, 21), ExpiryDate = new DateTime(2026, 3, 21), Quantity = 1, Unit = "jar", Notes = "Homemade", Status = ItemStatus.Active }
            );
        }

    }
}


