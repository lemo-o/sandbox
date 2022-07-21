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


        private static readonly By[][] _bannerBy =
        {
            new By[] {
                By.XPath("//div[3]/ul/li[1]"),//Home button
                By.XPath("//li[1]/ul/li[1]"), //Reports
                By.XPath("//li[1]/ul/li[2]"), //Dashboards
                By.XPath("//li[1]/ul/li[3]"), //Run Miles
                By.XPath("//li[1]/ul/li[4]"), //Office Config
                By.XPath("//li[1]/ul/li[5]")  //DoE Fuel Prices
            }, //6

            new By[] {
                By.XPath("//div[3]/ul/li[2]"),//Customers
                By.XPath("//li[2]/ul/li[1]"), //Search
                By.XPath("//li[2]/ul/li[2]"), //Leads
                By.XPath("//li[2]/ul/li[3]"), //Active
                By.XPath("//li[2]/ul/li[4]"), //New Lead
                By.XPath("//li[2]/ul/li[5]"), //Quotes
                By.XPath("//li[2]/ul/li[6]"), //Notes Search
                By.XPath("//li[2]/ul/li[7]"), //Billing Queue
                By.XPath("//li[2]/ul/li[8]")  //Invoice Queue
            }, //9

            new By[] {
                By.XPath("//div[3]/ul/li[3]"),//Loads
                By.XPath("//li[3]/ul/li[1]"), //Search
                By.XPath("//li[3]/ul/li[2]"), //Create TL
                By.XPath("//li[3]/ul/li[3]"), //Quotes
                By.XPath("//li[3]/ul/li[4]"), //Templates
                By.XPath("//li[3]/ul/li[5]"), //Active 
                By.XPath("//li[3]/ul/li[6]"), //Working
                By.XPath("//li[3]/ul/li[7]"), //Deliv Final
                By.XPath("//li[3]/ul/li[8]"), //Invoiced
                By.XPath("//li[3]/ul/li[9]")  //Batch Import
            }
        };
    }
}
