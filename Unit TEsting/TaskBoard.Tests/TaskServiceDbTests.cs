using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using TaskBoard.Data;
using TaskBoard.Services;
using TaskBoard.Models;
using System.Threading.Tasks;
using System.Linq;

namespace TaskBoard.Tests
{
    [TestFixture]
    public class TaskServiceDbTests
    {
        private AppDbContext _context;
        private TaskService _service;

        // Task 2: Create a new test class TaskServiceDbTests and configure DbContextOptionsBuilder to use .UseInMemoryDatabase().
        
        [SetUp]
        public void SetUp()
        {
            // Task 1: Install Microsoft.EntityFrameworkCore.InMemory (Done)
            
            // Task 2 & 3: Initialize the in-memory database with 3 sample tasks before each test runs.
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "Test_Database_" + System.Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options);
            _service = new TaskService(_context);

            // Seed data
            _context.Tasks.AddRange(new[]
            {
                new TaskBoard.Models.Task { Title = "Task 1", Description = "Desc 1" },
                new TaskBoard.Models.Task { Title = "Task 2", Description = "Desc 2" },
                new TaskBoard.Models.Task { Title = "Task 3", Description = "Desc 3" }
            });
            _context.SaveChanges();
        }

        [TearDown]
        public void TearDown()
        {
            // Task 3: Use the [TearDown] attribute to clean it up.
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public async System.Threading.Tasks.Task GetAllTasks_ReturnsSeededItems()
        {
            // Task 4: Write a test that calls the GetAllTasks() method and assert that it accurately retrieves the items seeded in the database.
            
            // Act
            
            // Assert
        }
    }
}
