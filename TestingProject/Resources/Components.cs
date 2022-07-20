using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Components : BaseComponent
    {
        public Components(IBrowsers driver, By locator) : base(driver, locator) { }

        public void SendKeys(string text) => FindElement().SendKeys(text);
        public void Click() => FindElement().Click();
        public void Hover()
        {
            Actions action = new Actions(base.driver.CurrentDriver());
            action.MoveToElement(FindElement()).Perform();
        }
    }
}
