using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumAutomation_1
{
    [TestClass]
    public class Iframe
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(var driver= new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("D://Simpli Learn//Dot_net//Demo//iframe.html");

                //for me i had prepared dummy html file with iframe
                //my path is : D://Simpli Learn//Dot_net//Demo//iframe.html

                //wait time
                new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until
                    (d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                Console.WriteLine("Document Loaded");

                var iframe = driver.FindElements(By.TagName("iframe"));
                Assert.IsTrue(iframe.Count == 2);

                driver.SwitchTo().Frame(0);
                Console.WriteLine("I frame Switched");


                //task : search for a website and check for numbers of iframes
                
            }

        }
    }
}
