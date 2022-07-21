using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class BannerButtons 
    {
        public BannerButtons(IBrowsers driver)
        {
            //this navigation needs to be fixed.
            var banner = new Banner(driver);
            banner.HomeButtonClick();
            banner.HomeNavigation();
            banner.ReportsClick();
            banner.HomeNavigation();
            banner.DashboardsClick();
            banner.HomeNavigation();
            banner.RunMilesClick();
            banner.HomeNavigation();
            banner.OfficeConfigClick();
            banner.HomeNavigation();
            banner.DoeFuelPricesClick();
            banner.HomeNavigation();
        }
    }
}
