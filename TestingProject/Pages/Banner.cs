using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace Selenium
{
    public class Banner : BaseComponent 
    {

        public Banner(IBrowsers driver) : base(driver) { }

        private void BannerButtons(int header) //starts at 1
        {
            Components _component = new Components(driver, By.XPath($"//div[3]/ul/li[{header}]"));
            _component.Click();
        }
        private void BannerButtons(int header, int dropdown) //starts at 1
        { 
            Components _component = new Components(driver, By.XPath($"//div[3]/ul/li[{header}]"));
            _component.Hover();
            _component = new Components(driver, By.XPath($"//li[{header}]/ul/li[{dropdown}]"));
            _component.Click();
        }

        public void HomeNavigation() => driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[2]);
        public void HomeButtonClick() => BannerButtons(1); 
        public void ReportsClick() =>       BannerButtons(1, 1);
        public void DashboardsClick() =>    BannerButtons(1, 2);
        public void RunMilesClick() =>      BannerButtons(1, 3);
        public void OfficeConfigClick() =>  BannerButtons(1, 4);
        public void DoeFuelPricesClick() => BannerButtons(1, 5);
        public void CreateTLClick() => BannerButtons(3, 2);
    }
}
