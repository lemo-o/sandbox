using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Dropdowns : BaseComponent //This is currently not being used
    {
        public Dropdowns(IBrowsers driver, By locator) : base(driver, locator) 
        {
            //kinda just doubled up buttons; just using buttons twice on a page module does the same thing
            //Since BTMS has like 4 or 5 different styles, it's easiest to just handle them in the page classes
        }

        public void Type2() //Click
        {

        }

        public void Type3() //
        {

        }

    }
}
