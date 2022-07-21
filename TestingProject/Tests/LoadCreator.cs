using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class LoadCreator
    {
        public LoadCreator(IBrowsers driver)
        {
            Random rand = new Random();
            var TLpage = new CreateTL(driver);
            TLpage.CustomerFieldButton();
            TLpage.ShipperName(Constants.Names[rand.Next(0, Constants.Names.Length)]);
            TLpage.ShipperAddress1(Constants.Address1[rand.Next(0, Constants.Address1.Length)]);
            TLpage.ShipperAddress2(Constants.Address2[rand.Next(0, Constants.Address2.Length)]);
            TLpage.ShipperZIP(Constants.CityBlocks[rand.Next(0, 1)][5]);
            TLpage.ShipperEarliestDate(DateTime.Now.ToString("M/d/yyyy"));
            TLpage.ConsigneeName(Constants.Names[rand.Next(0, Constants.Names.Length)]);
            TLpage.ConsigneeAddress1(Constants.Address1[rand.Next(0, Constants.Address1.Length)]);
            TLpage.ConsigneeAddress2(Constants.Address2[rand.Next(0, Constants.Address2.Length)]);
            TLpage.ConsigneeZIP(Constants.CityBlocks[rand.Next(0, 1)][5]);
            TLpage.ConsigneeEarliestDate(DateTime.Now.ToString("M/d/yyyy"));
            TLpage.Quantity(rand.Next(0, 10).ToString());
            TLpage.UnitOfMeasurement();
            TLpage.Description("stuff");
            TLpage.EquipmentType();
            TLpage.Weight(rand.Next(0, 150000).ToString());
            TLpage.MileageEngine(0);
            TLpage.Method(0);
            TLpage.CreateLoadButton();
        }
    }
}
