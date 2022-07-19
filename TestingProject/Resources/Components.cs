using OpenQA.Selenium;

namespace Selenium
{
    internal class Component : BaseComponent
    {
        public Component(IBrowsers driver, By locator) : base(driver, locator) { }

        public void SendKeys(string text) => FindElement().SendKeys(text);
        public void Click() => FindElement().Click();
    }
}
