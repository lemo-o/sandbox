using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public interface IBrowsers
    {
        IWebDriver CurrentDriver();
        //object Navigate();
        //IWebDriver ChromeDriver();
        //Edge();
        //Firefox();

    }

    class Driver : IBrowsers
    {
        private IWebDriver _driver;
        public Driver()
        {
            _driver = new ChromeDriver(); //variable names will need to be changed for clarity for multiple browsers
        }
        public IWebDriver CurrentDriver() //this is new
        {
            return _driver;
        }

    }
}






