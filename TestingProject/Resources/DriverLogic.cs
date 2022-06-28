using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{ 
    abstract class DriverStart
    {
        public abstract IWebDriver Driver();
    }

    class Chrome : DriverStart
    {
        private IWebDriver _driver;

        public Chrome()
        {
            _driver = new ChromeDriver();
        }

        public override IWebDriver Driver()
        {
            return _driver;
        }
    }
    //^^^essentially copy paste for Firefox and Edge with a switch statement handling which browser instance to create
}
