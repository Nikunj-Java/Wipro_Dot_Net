using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumAutomation_1
{
    
    class AdvanceFramework
    {
        [Test]
        public void TestMethod1()
        {

            //initializing google chrome driver and opening url
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.simplilearn.com/";
            driver.Manage().Window.Maximize();


            //screenshot : optional
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile("D:/Simpli Learn/Dot_net/Demo/home.png", ScreenshotImageFormat.Png);
            Console.WriteLine("Screenshot saved Successfully");

            Aboutusclass about = new Aboutusclass(driver);
            PageFactory.InitElements(driver, this);
        }
    }
}
