using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    class Working
    {
        static void Main(string[] args)
        {
            IBrowsers driver = new Driver();
            new Login(driver);
            Banner bannerButtons = new Banner(driver);
            bannerButtons.CreateTLClick();
            new LoadCreator(driver);      
        }
    }
}