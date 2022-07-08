using OpenQA.Selenium;

namespace Selenium
{
    public class Dropdowns : BaseComponent
    {
        public Dropdowns(IBrowsers driver, By locater) // this currently does not work/do anything
        {
            Locator = locater;
            Driver = driver;
        }
    }
}
