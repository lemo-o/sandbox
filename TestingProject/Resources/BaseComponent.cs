using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace Selenium //my next step is to change most of these to have correct private/public consolidation. 
{
    public class BaseComponent
    {
        private protected IBrowsers driver { get; set; }
        private protected By locator { get; set; }

        public IBrowsers Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public BaseComponent() { } 

        public BaseComponent(IBrowsers driver)
        {
            this.driver = driver;
        }

        public BaseComponent(IBrowsers driver, By locater)
        {
            locator = locater;
            this.driver = driver;
        }
        protected internal IWebElement FindElement() => WaitForElement();

        protected internal IWebElement WaitForElement() => new WebDriverWait(driver.CurrentDriver(), TimeSpan.FromSeconds(15)).Until<IWebElement>(drv => { return drv.FindElement(locator); });

        protected internal void DriverExit() => driver.CurrentDriver().Close();
    }
}
