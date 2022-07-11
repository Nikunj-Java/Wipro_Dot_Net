using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumAutomation_1
{
    [TestClass]
    public class AlertBox
    {
        [TestMethod]
        public void TestMethod1()
        {
                var driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://nxtgenaiacademy.com/alertandpopup/");

                //this step produce an alert on the screen
                driver.FindElement(By.Name("alertbox")).Click();

                //switching the control of 'driver' tom the alert from main window
                IAlert alert = driver.SwitchTo().Alert();

                //Accept() is used to accepet the alert
                alert.Accept();
                Console.WriteLine("alert accepted");

               //get the text from alert box
                

                 

             
        }
    }
}
