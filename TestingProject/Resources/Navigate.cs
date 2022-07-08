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
        public void QCNav() //I guess I ~could~ put this in BaseComponent, but considering this is not as frequently used by different classes, it doesn't make sense to put there.
        {
            Driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[0]);
        }
        public void StageNav() //I guess I ~could~ put this in BaseComponent, but considering this is not as frequently used by different classes, it doesn't make sense to put there.
        {
            Driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[1]);
        }
    }
}
