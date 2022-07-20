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
            var loginPage = new LoginPage(driver);
            loginPage.Navigation();
            loginPage.UsernameFill(Constants.Usernames[0]);
            loginPage.PasswordFill(Constants.Passwords[0]);
            loginPage.LoginButton();
            var banner = new Banner(driver);
            banner.CreateTLClick();
            var TLpage = new CreateTL(driver);
            TLpage.CustomerField();
            TLpage.ShipperName();
            TLpage.ShipperAddress1();
            TLpage.ShipperAddress2();
            TLpage.ShipperZIP();
            TLpage.ShipperEarliestDate();
            TLpage.ConsigneeName();
            TLpage.ConsigneeAddress1();
            TLpage.ConsigneeAddress2();
            TLpage.ConsigneeZIP();
            TLpage.ConsigneeEarliestDate();
            TLpage.Quantity();
            TLpage.UnitOfMeasurement();
            TLpage.Description();
            TLpage.EquipmentType();
            TLpage.Weight();
            TLpage.MileageEngine();
            TLpage.Method();
        }
    }
}
