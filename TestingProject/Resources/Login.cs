using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Login
    {
        public void LoginPage()
        {
            IBrowsers driver = new Driver();
            Navigate QC = new Navigate(driver);
            QC.QCNav();
            Textbox username = new Textbox(driver, By.Id("agent_login"));
            username.SendKeys(Constants.Usernames[0]);
            Textbox password = new Textbox(driver, By.Id("agent_password"));
            password.SendKeys(Constants.Passwords[0]);
            Button button = new Button(driver, By.XPath("//div[4]/input"));
            button.Click();
        }
    }
}


