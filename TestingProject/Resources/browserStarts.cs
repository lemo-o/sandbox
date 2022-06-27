using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace seleniumTest
{
    public class Chrome
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver() //singleton method - this is terrible for multiple-browser tests
        {
            if (_driver == null)
            {

                //var service = ChromeDriverService.CreateDefaultService();
                //service.HideCommandPromptWindow = true;

                //var options = new ChromeOptions();
                //options.AddArguments("--headless");

                //var commandTimeout = TimeSpan.FromSeconds(30);

                _driver = new ChromeDriver(/*service, options, commandTimeout*/);
            }
            return _driver;
        }
    }
}