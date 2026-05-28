using NUnit.Framework;
using Moq;
using TaskBoard.Services;
using TaskBoard.Models;
using TaskBoard.Data;
using System.Threading.Tasks;

namespace TaskBoard.Tests
{
    [TestFixture]
    public class TaskServiceTests
    {
        // Task 1: Create a test class named TaskServiceTests using the NUnit framework. (Done)
        
        // Task 2: Use the AAA pattern (Arrange, Act, Assert) to structure the test methods.
        
        [Test]
        public async System.Threading.Tasks.Task CreateTask_WithValidInput_ReturnsSuccessMessage()
        {
            // Task 3: Since the service depends on external components, 
            // use the Moq library to mock the ITaskRepository or database dependency.
            // Hint: In this case, we'll mock the AppDbContext if we were using a repository, 
            // but since TaskService uses AppDbContext directly, you might want to mock 
            // the ITaskService itself for controller tests, or use InMemory for service tests.
            // For Exercise 1, let's assume we are mocking a dependency of the service if it had one.
            // Since our TaskService is simple, students can practice mocking a hypothetical repository.
            
            // Arrange
            // var mockRepo = new Mock<ITaskRepository>();
            // var service = new TaskService(mockRepo.Object);

            // Act
            
            // Assert
            // Assert.That(result, Is.EqualTo("Success"));
        }
    }
}
