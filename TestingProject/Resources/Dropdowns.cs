using OpenQA.Selenium;

namespace Selenium
{
    public class Dropdowns : BaseComponent
    {
        private IBrowsers _driver;
        private By _locator;

        public Dropdowns(IBrowsers driver, By locater)
        {
            _locator = locater;
            _driver = driver;
        }

    }

}
