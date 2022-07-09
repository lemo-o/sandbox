﻿using OpenQA.Selenium;
namespace Selenium
{
    public class Textbox : BaseComponent
    {

        public Textbox(IBrowsers driver, By locator) : base(driver, locator) { }

        public void SendKeys(string text)
        {
            FindElement().SendKeys(text);
        }

    }
}
