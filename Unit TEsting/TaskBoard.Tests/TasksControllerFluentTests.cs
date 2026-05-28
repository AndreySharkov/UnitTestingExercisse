using NUnit.Framework;
using MyTested.AspNetCore.Mvc;
using TaskBoard.Controllers;
using TaskBoard.Models;
using System.Collections.Generic;

namespace TaskBoard.Tests
{
    [TestFixture]
    public class TasksControllerFluentTests
    {
        // Task 1: Install the MyTested.AspNetCore.Mvc.Universe NuGet package. (Done)

        [Test]
        public void Index_ReturnsViewWithCorrectModel()
        {
            // Task 2: Write a fluent test for the TasksController.
            // Task 3: Verify that calling the specific action returns a valid model state, 
            // returns a View, and passes the correct model type to that view using 
            // the .ShouldHave().ValidModelState() and .ShouldReturn().View(...) extensions.
            
            /*
            MyMvc
                .Controller<TasksController>()
                .Calling(c => c.Index())
                .ShouldReturn()
                .View(view => view
                    .WithModelOfType<IEnumerable<TaskBoard.Models.Task>>());
            */
        }
    }
}
