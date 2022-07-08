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
        private IWebDriver _currentWebDriver() //Is there any reason that I can't just do this? Maybe this should just stay in the format _currentWebDriver(browser) in IBrowsers
        {
            return Driver.CurrentDriver();
        }
        protected internal IWebElement FindElement()
        {
            return WaitForElement();
        }
        protected internal IWebElement WaitForElement()
        {
            return new WebDriverWait(Driver.CurrentDriver(), TimeSpan.FromSeconds(15)).Until<IWebElement>(drv => { return drv.FindElement(Locator); });
        }
        protected internal IWebDriver DriverImplicitWait(int time) //this does not work
        {
            Driver.CurrentDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            return null;
        }
        //protected internal IWebElement XPathFindElement() //hmmmmmmm ohhhhhhhhhhhh ~~~~ later on ~~~~ OHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH. There is ~character development~ going on in this piece of code
        //{
        //    return Driver.CurrentDriver().FindElement(Locator); 
        //}

        //protected internal IWebElement IdFindElement() //these are redundant now though haha
        //{
        //    return Driver.CurrentDriver().FindElement(Locator);
        //}

        protected internal void DriverExit()
        {
            Driver.CurrentDriver().Close();
        }
    }
}
