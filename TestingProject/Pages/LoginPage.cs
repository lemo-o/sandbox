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
        //private TextBoxList textboxes = new TextBoxList();
        //private ButtonList buttons = new ButtonList();
        private ComponentList _components = new ComponentList();

        public LoginPage(IBrowsers driver) : base(driver) 
        {
            _components.CurrentComponentList.Add((new Components(driver, By.Id("agent_login")), "username"));
            _components.CurrentComponentList.Add((new Components(driver, By.Id("agent_password")), "password"));
            _components.CurrentComponentList.Add((new Components(driver, By.XPath("//div[4]/input")), "Log In Button"));
        }
        public void Navigation() => driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[0]);
        public void UsernameFill(string input) => _components.CurrentComponentList[0].component.SendKeys(input);
        public void PasswordFill(string input) => _components.CurrentComponentList[1].component.SendKeys(input);
        public void LoginButton() => _components.CurrentComponentList[2].component.Click();
    }
}


