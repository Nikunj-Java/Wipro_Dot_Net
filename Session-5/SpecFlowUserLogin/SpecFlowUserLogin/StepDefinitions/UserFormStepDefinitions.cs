using System;
using TechTalk.SpecFlow;

namespace SpecFlowUserLogin.StepDefinitions
{
    [Binding]
    public class UserFormStepDefinitions
    {
        [Given(@"I have loaded the webpage again")]
        public void GivenIHaveLoadedTheWebpageAgain()
        {
            Console.WriteLine("I have loaded the webpage again");
        }

        [Given(@"I have entere userid and password again")]
        public void GivenIHaveEntereUseridAndPasswordAgain(Table table)
        {
            Console.WriteLine("I have entere userid and password again");
        }

        [Given(@"I fill in the message form with data again")]
        public void GivenIFillInTheMessageFormWithDataAgain(Table table)
        {
            Console.WriteLine("I fill in the message form with data again");
        }

        [Then(@"I click submit button again")]
        public void ThenIClickSubmitButtonAgain()
        {
            Console.WriteLine("I click submit button again");
        }
    }
}
