using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace Selenium
{
    public class LoginPage : BaseComponent
    {
        public LoginPage(IBrowsers driver) : base(driver) { }
        public void Navigation(int input) => driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[input]);
        public void UsernameFill(string input)
        { 
            Components _component = new Components(driver, By.Id("agent_login"));
            _component.SendKeys(input);
        }
        public void PasswordFill(string input) 
        {
            Components _component = new Components(driver, By.Id("agent_password"));
            _component.SendKeys(input);
        }
        public void LoginButton() 
        {
            Components _component = new Components(driver, By.XPath("//div[4]/input"));
            _component.Click();
        }
    }
}


