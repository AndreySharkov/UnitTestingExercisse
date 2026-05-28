# TaskBoard Testing Workshop

Welcome to the TaskBoard Testing Workshop! This project is designed to help you practice various testing techniques in ASP.NET Core.

## Project Structure

- **TaskBoard**: The main MVC application.
  - `Models/Task.cs`: The core data model.
  - `Data/AppDbContext.cs`: The Entity Framework Core database context.
  - `Services/TaskService.cs`: Contains the business logic for managing tasks.
  - `Controllers/TasksController.cs`: Handles web requests.
- **TaskBoard.Tests**: The testing project where you will write your tests.

## Exercises

### Exercise 1: Unit Testing & Mocking (NUnit & Moq)
Open `TaskServiceTests.cs`. Your goal is to test the business logic in isolation using Moq to handle dependencies.

### Exercise 2: Testing with an In-Memory Database
Open `TaskServiceDbTests.cs`. Practice testing the service layer with a real database context using the EF Core In-Memory provider.

### Exercise 3: Integration Testing
Open `TaskIntegrationTests.cs`. Test the interaction between the application's APIs and the server using `WebApplicationFactory`.

### Exercise 4: End-to-End UI Testing with Selenium
Open `SeleniumTests.cs`. Simulate user interactions in a real browser. 
*Note: Ensure you have Chrome and ChromeDriver installed on your machine.*

### Exercise 5 (Bonus): Fluent MVC Testing
Open `TasksControllerFluentTests.cs`. Use the `MyTested.AspNetCore.Mvc` library to write expressive, fluent tests for your controllers.

## How to Run

1. Build the solution: `dotnet build`
2. Run the tests: `dotnet test`
