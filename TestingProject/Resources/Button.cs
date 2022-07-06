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
        Button(IBrowsers driver, By locator) 
        {
            this._driver = driver;
            this._locator = locator;
        }

        public IWebElement Bttn()
        {
             return FindElement(drv => { return drv.FindElement(_locator); });
        }
        //            var tempbutton = Chrome.Driver().FindElement(By.XPath(location));
        //            tempbutton.Click();


    }
}
