using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace seleniumTest //my next step is to change most of these to have correct private/public consolidation. 
{

    

    public class generalHandlers
    {
        public generalHandlers() { }


        public void browserStart(string temp) //also navigates to page
        {
            //driver = new Chrome().Driver;
            Chrome.Driver().Navigate().GoToUrl(temp);
            Chrome.Driver().Manage().Window.Maximize();
            //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }
        public void dropdownHandler(string x, string y /*, string l2, string l3 */) //input the xml for a dropdown and their respective codes 
        {
            Actions action = new Actions(Chrome.Driver());

            var dropdown = Chrome.Driver().FindElement(By.XPath(x));

            action.MoveToElement(dropdown).Perform(); //xpath doesn't work for something reason? use the id - ID doesn't work? It's probably a clicking box; therefore, click the box, then check for xpath again
            try
            {
                var level_1 = Chrome.Driver().FindElement(By.XPath(y));
                level_1.Click();
            }
            catch
            {
                try
                {
                    var level_1 = Chrome.Driver().FindElement(By.Id(y));
                    level_1.Click();
                }
                catch
                {
                    dropdown.Click();
                    var level_1 = Chrome.Driver().FindElement(By.XPath(y));
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
        public void textboxHandler(string location, string text) //this section needs errorchecking
        {
            var temp = Chrome.Driver().FindElement(By.XPath(location));
            temp.SendKeys(text);
        }
        public void loginPage(string login, string pw) //this can 100% be cleverer - current it's not "generalized" Past that, it lacks errorchecking
        {
            var username = Chrome.Driver().FindElement(By.XPath("//*[@id='agent_login']"));
            username.SendKeys(login);

            var password = Chrome.Driver().FindElement(By.XPath("//*[@id='agent_password']"));
            password.SendKeys(pw);

            password.Submit();
        }
        public void buttonHandler(string location)
        {
            //add a class for this later
            var tempbutton = Chrome.Driver().FindElement(By.XPath(location));
            tempbutton.Click();

            Chrome.Driver().Close();
        }
    }
}