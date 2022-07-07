namespace Selenium
{
    public class Textbox : BaseComponent
    {
        public void SendKeys(string text)
        {
            FindElement().SendKeys(text);
        }
    }
}
