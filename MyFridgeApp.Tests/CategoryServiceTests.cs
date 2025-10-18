using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using MyFridgeApp.Services;
using MyFridgeApp.Data;

namespace MyFridgeApp.Tests
{
    [TestFixture]
    public class CategoryServiceTests
    {
        [SetUp]
        public void ResetDatabase()
        {
            using var ctx = new Context();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated(); 
        }

        [Test]
        public async Task GetAllAsync_Should_Return_Seeded_Categories_In_Name_Order()
        {
            // Arrange
            var svc = new CategoryService();

            // Act
            var list = await svc.GetAllAsync();

            // Assert
            Assert.That(list, Is.Not.Null, "Category list should not be null");
            Assert.That(list.Any(), Is.True, "Category list should contain items");
            Assert.That(list.Select(c => c.Name).ToArray(), Is.Ordered, "Categories should be sorted by Name");
        }
    }
}
