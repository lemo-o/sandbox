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
<<<<<<< HEAD
            IBrowsers driver = new Driver();
            new Login(driver);
            Banner bannerButtons = new Banner(driver);
            bannerButtons.CreateTLClick();
            new LoadCreator(driver);      
=======
            new LoadCreator();
>>>>>>> 7567ed4ea0353eaaff72bc2e5a4b9f2ee12ddcfc
        }
    }
}