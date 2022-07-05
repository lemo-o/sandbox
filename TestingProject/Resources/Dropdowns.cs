using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class Dropdowns : BaseComponent
    {
        private IBrowsers _driver;
        private By _locator;

        public Dropdowns(IBrowsers driver, By locater)
        {
            _locator = locater;
            _driver = driver;
        }

    }

}
