using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDSelenium.StepDefinitions
{
    [Binding]
    public class FacebookStepDefinitions
    {

        private String emailKeyword;
        private String passKeyword;

        private ChromeDriver driver;

        [Given(@"I have navigated to facebook page")]
        public void GivenIHaveNavigatedToFacebookPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.facebook.com");
        }

        [Given("I have entered (.*) as email keyword")]
        public void GivenIHaveEnteredNikunjGmail_ComAsEmailKeyword(string email)
        {
            this.emailKeyword = email;
            var EMAIL=driver.FindElement(By.Name("email"));
            EMAIL.SendKeys(emailKeyword);

        }
        [Given("I have entered (.*) as password keyword")]
        public void GivenIHaveEnteredAsPasswordKeyword(string password)
        {
            this.passKeyword = password;
            var EMAIL = driver.FindElement(By.Name("pass"));
            EMAIL.SendKeys(passKeyword);

        }


        [When(@"I press the login button")]
        public void WhenIPressTheLoginButton()
        {
            driver.FindElement(By.Name("login")).Click();
            
        }

        [Then(@"then i will be abled to logged in")]
        public void ThenThenIWillBeAbledToLoggedIn()
        {
            Console.WriteLine("Testing is Done");
        }
    }
}
