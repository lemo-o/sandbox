using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public interface IBrowsers
    {
        IWebDriver CurrentDriver();
        By Locator();
        //object Navigate();
        //IWebDriver ChromeDriver();
        //Edge();
        //Firefox();

    }
    class Driver : IBrowsers
    {
        private IWebDriver _driver;
        private By _locator;
        public Driver()
        {
            _driver = new ChromeDriver();            //variable names will need to be changed for clarity for multiple browsers
        }
        public IWebDriver CurrentDriver()
        {
            return _driver;
        }
        public By Locator()
        {
            return _locator;
        }
    }
}






