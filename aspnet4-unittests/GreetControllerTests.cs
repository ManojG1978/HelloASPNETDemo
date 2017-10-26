using System;
using System.Web.Mvc;
using aspnet4_sample.Controllers;
using aspnet4_sample.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aspnet4_tests
{
    [TestClass]
    public class GreetControllerTests
    {
        [TestMethod]
        public void WhenNameIsProvided_Should_ReturnAGreeting()
        {
            GreetController controller = new GreetController();
            var model = new GreetModel {Name = "John"};
            var actionResult = controller.Greet(model);
            Assert.IsTrue(model.Greeting != null);
            Assert.AreEqual(model.Greeting, "Hello! " + model.Name);

        }

        [TestMethod]
        public void WhenNameIsNotProvided_ShouldNot_ReturnAGreeting()
        {
            GreetController controller = new GreetController();
            var model = new GreetModel { Name = "" };
            var actionResult = controller.Greet(model);
            Assert.IsTrue(string.IsNullOrEmpty(model.Greeting));
            
        }

    }
}
