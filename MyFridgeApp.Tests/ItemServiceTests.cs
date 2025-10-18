using System;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFridgeApp.Services;
using MyFridgeApp.Models;
using MyFridgeApp.Data;
using Microsoft.EntityFrameworkCore;

namespace MyFridgeApp.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        [SetUp]
        public void ResetDatabase()
        {
            using var ctx = new Context();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        [Test]
        public async Task CreateAsync_Should_Persist_Item_And_Set_ImportDate_Default()
        {
            // Arrange
            var svc = new ItemService();
            var newItem = new Item
            {
                Name = "UnitTest Milk",
                CategoryId = 5,  
                Quantity = 1,
                Unit = "bottle"
            };

            // Act
            var created = await svc.CreateAsync(newItem);

            // Assert
            using var verifyCtx = new Context();
            var saved = await verifyCtx.Items.SingleAsync(i => i.Id == created.Id);

            Assert.That(saved, Is.Not.Null, "Item should be saved");
            Assert.That(saved.Name, Is.EqualTo("UnitTest Milk"));
            Assert.That(saved.CategoryId, Is.EqualTo(5));
            Assert.That(saved.ImportDate.Date, Is.EqualTo(DateTime.Today), "ImportDate should default to today");
        }
    }
}
