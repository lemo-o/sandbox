using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium //my next step is to change most of these to have correct private/public consolidation. 
{


    public class GeneralHandlers
    { 
        public GeneralHandlers() { } //constructor

        public void BrowserStart(string temp) //also navigates to page
        {
            Chrome.Driver().Navigate().GoToUrl(temp);
            Chrome.Driver().Manage().Window.Maximize();
            //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }
        public void IDDropdownHandler(string _id1, string _id2)
        {

        }
        public void XDropdownHandler(string _xPath1, string _xPath2 /*, string l2, string l3 */) //input the xpath for a dropdown and their respective codes 
        {
            Actions action = new Actions(Chrome.Driver());

            var dropdown = Chrome.Driver().FindElement(By.XPath(_xPath1));

            action.MoveToElement(dropdown).Perform(); //logic is this: xpath doesn't work for something reason? use the id - ID doesn't work? It's probably a clicking box; therefore, click the box, then check for xpath again
            try
            {
                var level_1 = Chrome.Driver().FindElement(By.XPath(_xPath2));
                level_1.Click();
            }
            catch
            {
                try
                {
                    var level_1 = Chrome.Driver().FindElement(By.Id(_xPath2));
                    level_1.Click();
                }
                catch
                {
                    dropdown.Click();
                    var level_1 = Chrome.Driver().FindElement(By.XPath(_xPath2));
                    level_1.Click();
                }
            }

            /* Logic for this should be:
             * Check what is the "lowest" level entered
             * Navigate to the one before that level
             * Click on the lowest level
             */

            //this will probably need a pretty good waiting strategy. As of now, I wait implicitly in the main section of the code
        }
        public void TextboxHandler(string location, string text) //this section needs errorchecking
        {
            try
            {
                var temp = Chrome.Driver().FindElement(By.XPath(location));
                temp.Clear();
                temp.SendKeys(text);
            }
            catch
            {
                Chrome.Driver().Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
                var temp = Chrome.Driver().FindElement(By.XPath(location));
                temp.Clear();
                temp.SendKeys(text);
            }
        }

        public void TextboxHandler(string location) //presumes that it just wants the textbox cleared with no text entered
        {
            var temp = Chrome.Driver().FindElement(By.XPath(location));
            temp.Clear();
        }

        public void LoginPage(string login, string pw) //This section needs to take the xpath for the buttons/textboxes for the login
        {
            var username = Chrome.Driver().FindElement(By.XPath("//*[@id='agent_login']"));
            username.SendKeys(login);

            var password = Chrome.Driver().FindElement(By.XPath("//*[@id='agent_password']"));
            password.SendKeys(pw);

            password.Submit();
        }
        public void ButtonHandler(string location)
        {
            var tempbutton = Chrome.Driver().FindElement(By.XPath(location));
            tempbutton.Click();

            //Chrome.Driver().Close();
        }
    }
}