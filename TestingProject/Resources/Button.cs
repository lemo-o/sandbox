namespace Selenium
{
    public class Button : BaseComponent
    {
        //Button(IBrowsers driver, By locator) 
        //{
        //    _driver = driver;
        //    _locator = locator;
        //}

        public void Click()
        {
            FindElement().Click();
        }
    }
}
