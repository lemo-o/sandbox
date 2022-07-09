using OpenQA.Selenium;

namespace Selenium
{
    public class Button : BaseComponent
    {
        public Button(IBrowsers driver, By locator) : base(driver, locator) { FindElement().Click(); }
    }
}
