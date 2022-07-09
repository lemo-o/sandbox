using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium //my next step is to change most of these to have correct private/public consolidation. 
{
    public class BaseComponent
    {
        private protected IBrowsers Driver { get; set; }
        private protected By Locator { get; set; } //-look up how this works, future me! ~~~ Future me says that this is the start of a property that you're not using. 

        public BaseComponent() { } 

        public BaseComponent(IBrowsers driver, By locater)
        {
            Locator = locater;
            Driver = driver;
        }
        protected internal IWebElement FindElement() => WaitForElement();

        protected internal IWebElement WaitForElement()
        {
            return new WebDriverWait(Driver.CurrentDriver(), TimeSpan.FromSeconds(15)).Until<IWebElement>(drv => { return drv.FindElement(Locator); });
        }
        protected internal IWebDriver DriverImplicitWait(int time) //this does not work
        {
            Driver.CurrentDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            return null;
        }

        protected internal void DriverExit() => Driver.CurrentDriver().Close();
    }
}
