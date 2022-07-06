using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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
