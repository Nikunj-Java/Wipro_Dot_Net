using SpecFlowCalculatorDemo;


namespace SpecFlowProjectLogin.Specs.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly Login _loggedin = new Login();

        private int _result;
        private readonly ScenarioContext _scenarioContext;

        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the email id ""(.*)""")]
        public void GivenTheEmailId(string email)
        {
            _loggedin.FirstNumber = email;
        }

        [When(@"the password is ""(.*)""")]
        public void WhenThePasswordIs(string password)
        {
            _scenarioContext.Pending();
        }

        [Then(@"result is (.*)")]
        public void ThenResultIs(int p0)
        {
            _scenarioContext.Pending();
        }
    }
}
