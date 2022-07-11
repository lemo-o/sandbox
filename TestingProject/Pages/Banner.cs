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
        private TextBoxList textboxes = new TextBoxList();
        private ButtonList buttons = new ButtonList();
        public Banner(IBrowsers driver) : base(driver)
        {
            for (int g = 0; g < _bannerBy.Length; g++)
            {
                for (int i = 0; i < _bannerBy[g].Length; i++)
                {
                    buttons.CurrentButtonList.Add((new Button(driver, _bannerBy[g][i]), _bannerString[g][i]));
                }
            }
        }

        private void BannerDropdown(int banner, int index)
        {
            //buttons.CurrentButtonList.Single(input); //here's the idea - using LINQ to search the index part of the list to return whatever button you need quickly and easily
            //i just can't make it work so right now it's just janky, 

            Hover _currentButton = new Hover(driver, _bannerBy[banner][0]);
            _currentButton.MouseOver();
            buttons.CurrentButtonList[index].button.Click();

            //new Hover(driver, _bannerBy[mainButton][0]); 
            //buttons.CurrentButtonList[mainButton * subMenu].button.Click();

        }

        //public void HomeButtonClick() => buttons.CurrentButtonList[0].button.Click();
        public void ReportsClick() =>       BannerDropdown(0, 1);
        //public void DashboardsClick() =>    //BannerDropdown(0, 2);
        //public void RunMilesClick() =>      //BannerDropdown(0, 3);
        //public void OfficeConfigClick() =>  //BannerDropdown(0, 4);
        //public void DoeFuelPricesClick() => //BannerDropdown(0, 5);

        public void CreateTLClick() => BannerDropdown(2, 17);


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

        private static readonly string[][] _bannerString =
        {
            new string[] {
                "Home button    ",
                "Reports        ",
                "Dashboards     ",
                "Run Miles      ",
                "Office Config  ",
                "DoE Fuel Prices"
            },
            new string[]{
                "Customers    ",
                "Search       ",
                "Leads        ",
                "Active       ",
                "New Lead     ",
                "Quotes       ",
                "Notes Search ",
                "Billing Queue",
                "Invoice Queue"
            },
            new string[]{
                "Loads"    ,
                "Search"   ,
                "Create TL",
                "Quotes"   ,
                "Templates",
                "Active     ",
                "Working    ",
                "Deliv Final",
                "Invoiced   ",
                "Batch Import"
            }

        };

        public static int[] BannerArrayLengths =
        {
            _bannerBy[0].Length,
            _bannerBy[1].Length,
            _bannerBy[2].Length
        }; 

   






    }
}
