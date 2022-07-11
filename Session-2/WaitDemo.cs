using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumAutomation_1
{
    [TestClass]
    public class WaitDemo
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver()) {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://www.google.com");


                //wait time
                new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until
                    (d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                Console.WriteLine("Document Loaded");
            }

        }
    }
}
