using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Navigate : BaseComponent
    {
        public Navigate(IBrowsers driver) : base(driver) { }
        public void Nav(string URL) 
        {
            driver.CurrentDriver().Navigate().GoToUrl(URL);
        }

    }
}
