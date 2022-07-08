using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class Navigate : BaseComponent
    {
        public Navigate(IBrowsers driver)
        {
           Driver = driver;
        }
        public void QCNav() 
        {
            Driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[0]);
        }
        public void StageNav() 
        {
            Driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[1]);
        }
    }
}
