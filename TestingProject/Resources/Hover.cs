using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace Selenium
{
    public class Hover : BaseComponent
    {
        public Hover(IBrowsers driver, By locator) : base(driver, locator) { }
        public void MouseOver()
        {
            Actions action = new Actions(base.driver.CurrentDriver());
            action.MoveToElement(FindElement()).Perform();
        }
    }
}
