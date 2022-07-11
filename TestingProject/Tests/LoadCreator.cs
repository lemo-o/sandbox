using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class LoadCreator
    {
        public LoadCreator()
        {
            IBrowsers driver = new Driver();
            Navigate nav = new Navigate(driver);
            nav.Nav(Constants.URLs[0]);
            var loginPage = new LoginPage(driver);
            loginPage.UsernameFill(Constants.Usernames[0]);
            loginPage.PasswordFill(Constants.Passwords[0]);
            loginPage.LoginButton();
            var banner = new Banner(driver);
            banner.CreateTLClick();
            var TLpage = new CreateTL(driver);
            TLpage.CustomerField();
            TLpage.ShipperName(Constants.Names[0]);
            TLpage.ShipperAddress1(Constants.Address1[0]);
            TLpage.ShipperAddress2(Constants.Address2[0]);
            TLpage.ShipperZIP(Constants.CityBlocks[0][5]);
            TLpage.ShipperEarliestDate("07 / 11 / 2022");
            TLpage.ConsigneeName(Constants.Names[1]);
            TLpage.ConsigneeAddress1(Constants.Address1[1]);
            TLpage.ConsigneeAddress2(Constants.Address2[1]);
            TLpage.ConsigneeZIP(Constants.CityBlocks[1][5]);
            TLpage.ConsigneeEarliestDate("07 / 11 / 2022");
            TLpage.Quantity("12");
            TLpage.UnitOfMeasurement();
            TLpage.Description("stuff");
            TLpage.EquipmentType();
            TLpage.Weight("123");
            TLpage.MileageEngine();
            TLpage.Method();
        }
    }
}
