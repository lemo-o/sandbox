using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    class Working
    {
        private static void Main()
        {
            IBrowsers driver = new Driver();
            new Login(driver);
            new BannerButtons(driver);
        }
    }
}