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
        private TextBoxList textboxes = new TextBoxList();
        private ButtonList buttons = new ButtonList();

        public LoginPage(IBrowsers driver) : base(driver) 
        {
            textboxes.CurrentTextboxList.Add((new Textbox(driver, By.Id("agent_login")), "username"));
            textboxes.CurrentTextboxList.Add((new Textbox(driver, By.Id("agent_password")), "password"));
            buttons.CurrentButtonList.Add( (new Button(driver, By.XPath("//div[4]/input")), "Log In Button"));
        }
        public void UsernameFill(string input) => textboxes.CurrentTextboxList[0].textbox.SendKeys(input);
        public void PasswordFill(string input) => textboxes.CurrentTextboxList[1].textbox.SendKeys(input);
        public void LoginButton() => buttons.CurrentButtonList[0].button.Click();
    }
}


