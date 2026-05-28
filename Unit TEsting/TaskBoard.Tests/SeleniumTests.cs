using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TaskBoard.Tests
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver _driver;
        private string _baseUrl = "https://localhost:5001"; // Change to your local app URL

        [SetUp]
        public void SetUp()
        {
            // Task 1: Create a SeleniumTests class and initialize a ChromeDriver.
            // Note: ChromeDriver requires the Chrome browser and driver to be installed.
            // _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            // Task 5: Ensure you call driver.Quit() at the end.
            _driver?.Quit();
        }

        [Test]
        public void AddTask_SuccessfullyRedirects()
        {
            // Task 2: Command the driver to navigate to the application's "Add Task" URL.
            // _driver.Navigate().GoToUrl(_baseUrl + "/Tasks/Create");

            // Task 3: Use .FindElement(By.Id("...")) to locate the input fields for the task's Title and Description.
            // var titleInput = _driver.FindElement(By.Id("task-title"));
            // var descInput = _driver.FindElement(By.Id("task-description"));

            // Task 4: Use .SendKeys(...) to simulate typing in a new task, 
            // and trigger a .Click() on the submit button.
            // titleInput.SendKeys("New UI Task");
            // descInput.SendKeys("Testing with Selenium");
            // _driver.FindElement(By.Id("create-button")).Click();

            // Task 5: Assert that the browser redirects successfully 
            // by checking if driver.Title contains the expected success page title.
            // Assert.That(_driver.Title, Contains.Substring("Tasks"));
        }
    }
}
