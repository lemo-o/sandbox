using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class Button : BaseComponent
    {
        //Button(IBrowsers driver, By locator) 
        //{
        //    _driver = driver;
        //    _locator = locator;
        //}

        public void Click()
        {
            FindElement().Click();
        }
    }
}
