using aspnet4_sample.Controllers;
using aspnet4_sample.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace aspnet4_sample.Specs
{
    [Binding]
    public class GreetSteps
    {
        private readonly GreetController _controller = new GreetController();
        private readonly GreetModel _model = new GreetModel();

        [Given(@"I have entered ""(.*)"" into the Greet Dialog")]
        public void GivenIHaveEnteredIntoTheGreetDialog(string p0)
        {
            _model.Name = p0;
        }

        [When(@"I press Greet")]
        public void WhenIPressGreet()
        {
            _controller.Greet(_model);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(_model.Greeting, p0);
        }
    }
}
