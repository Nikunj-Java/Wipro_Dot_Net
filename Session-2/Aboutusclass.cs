using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation_1
{
    class Aboutusclass
    {
        private IWebDriver driver;

        public Aboutusclass(IWebDriver drive) 
        {
        
            this.driver = drive;
            PageFactory.InitElements(driver, this);

            driver.Navigate().GoToUrl("https://www.simplilearn.com/about-us");

            //screenshot : optional
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile("D:/Simpli Learn/Dot_net/Demo/aboutus.png", ScreenshotImageFormat.Png);
            Console.WriteLine("Screenshot saved Successfully");


        }


    }
}
