using LoginTableDemo;

namespace SpecFlowProjectLogin.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Login login = new Login();
        private int _result;

           public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given("the email is (.*)")]
        public void GivenTheEmailIs(string email)
        {
         
            login.Email = email;
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string password)
        {
            login.Password = password;
        }

        [When(@"user enter email and password")]
        public void WhenUserEnterEmailAndPassword(Table table)
        {
            foreach (var row in table.Rows) 
            {

                _result = login.Check(row[0], row[1]);

            }

            
        }
        [Then(@"user authentication ends")]
        public void UserAuthenticationEnds()
        {
            Console.WriteLine("User Authentication Finished");
        }
    }
}