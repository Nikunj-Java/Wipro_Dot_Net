using System;
using TechTalk.SpecFlow;

namespace SpecFlowUserLogin.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I have loaded the webpage")]
        public void GivenIHaveLoadedTheWebpage()
        {
            Console.WriteLine("i have loaded the webpage");
        }

        [Given(@"I have entere userid and password")]
        public void GivenIHaveEntereUseridAndPassword(Table table)
        {
            Console.WriteLine("I have entere userid and password");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Console.WriteLine("I click login");
        }

        [Then(@"I should see the dashboard page")]
        public void ThenIShouldSeeTheDashboardPage()
        {
            Console.WriteLine("I should see the dashboard page");
        }
    }
}
