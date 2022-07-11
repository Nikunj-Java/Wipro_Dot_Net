using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
namespace SeleniumAutomation_1
{
    [TestClass]
    public class ScreenShot
    {
        [TestMethod]
        public void TestMethod1()
        {

            using (var driver = new ChromeDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://www.simplilearn.com");


                //wait time
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until
                    (d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                Console.WriteLine("Document Loaded");

                //screenshot

                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot= screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("D:/Simpli Learn/Dot_net/Demo/ScreenShot.png", ScreenshotImageFormat.Png);
                Console.WriteLine("Screenshot saved Successfully");

                //task: take atlease two screen shot of two different website


            }
        }
    }
}
