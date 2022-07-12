using NUnit.Framework;
using SpecFlowLoginProject.Utils;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;
 

namespace SpecFlowLoginProject.Specs.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly Login login = new Login();
        private int _result;

        private readonly ScenarioContext _scenarioContext;


        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
        }


        [Given("the email is (.*)")]
        public void GivenTheEmailIdIs(String email)
        {
            login.Email = email;
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string password)
        {
            login.Password = password;
        }

        [When("the email and password is matched")]
        public void WhenTheEmailIdAndPasswordIsMatched()
        {
            //TODO: implement act (action) logic

            _result = login.Check();
        }

        [Then(@"result should be (.*)")]
        
        public void ThenTheResultShouldBe(int result)
        {

            _result.Should().Be(result);
            Console.WriteLine("User Verified");
        }
    }
}