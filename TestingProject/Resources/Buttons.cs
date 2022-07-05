using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class Buttons : BaseComponent
    {
        private IBrowsers _driver;
        private By _locater;
        Buttons(IBrowsers driver, By locater)
        {
            _driver = driver;
            _locater = locater;
        }

    }
}
