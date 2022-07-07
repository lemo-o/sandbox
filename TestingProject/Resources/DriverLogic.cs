﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public interface IBrowsers
    {
        IWebDriver CurrentDriver();
        IWebElement Locator();
        //object Navigate();
        //IWebDriver ChromeDriver();
        //Edge();
        //Firefox();

    }

    class Driver : IBrowsers
    {
        private IWebDriver _driver;
        private IWebElement _locator;
        private Driver()
        {
            _driver = new ChromeDriver(); //variable names will need to be changed for clarity for multiple browsers
        }
        public IWebDriver CurrentDriver() //this is new
        {
            return _driver;
        }
        public IWebElement Locator()
        {
            return _locator;
        }

    }
}






