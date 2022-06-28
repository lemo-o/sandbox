using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class LoadCreator
    {

        GeneralHandlers constructor = new GeneralHandlers();
        Random _rand = new Random();

        public LoadCreator() { }

        public void ChangeThisName() 
        {
            _navigation();
            _customer();
            _shipper();
            _consignee();
            _shipmentCommodity();
            _equipmentRequirements();
            _distance();
            constructor.ButtonHandler("/html/body/div[2]/div[2]/form/div[9]/div/div/div[3]/button"); //submit
            _carrierTab();
            constructor.ButtonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[1]/table/tbody/tr/td[2]/div/input[6]");
        }

        private void _navigation() 
        {
            constructor.BrowserStart("https://brokerage.qc.suntecktts.com/agents/login");
            constructor.LoginPage("ben.hall", "Qll2mm.08");
            constructor.DropdownHandler("/html/body/header/nav/div/div/div[3]/ul/li[3]/a", "/html/body/header/nav/div/div/div[3]/ul/li[3]/ul/li[2]/a"); 
        }

        private void _customer() 
        {
            constructor.DropdownHandler("/html/body/div[2]/div[2]/form/div[2]/div[2]/div/div[1]/div[1]/div/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[3]");
        }

        private void _shipper() 
        {
            LocationDefinitions _tempDefinitions = new LocationDefinitions();
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[2]/div/input", _tempDefinitions.RandomizedItems[0]); //name
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[3]/div/input", _tempDefinitions.RandomizedItems[1]); //Address
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[6]/div/div/span[2]/input", _tempDefinitions.RandomizedItems[3]); //ZIP
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[13]/div[1]/div/input", DateTime.Now.ToString("M/d/yyyy")); //Earliest Date
        }

        private void _consignee() 
        {
            LocationDefinitions _tempDefinitions = new LocationDefinitions();
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[2]/div/input", _tempDefinitions.RandomizedItems[0]); //name
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[3]/div/input", _tempDefinitions.RandomizedItems[1]); //Address
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[6]/div/div/span[2]/input", _tempDefinitions.RandomizedItems[3]); //ZIP
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[13]/div[1]/div/input", DateTime.Now.ToString("M/d/yyyy"));
        }

        private void _shipmentCommodity() 
        {
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[2]/div/input", _rand.Next(1, 25).ToString()); //quantity
            constructor.DropdownHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[3]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); // UoM this should be made random
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[4]/div/input", "US 670 3' x 900' (300sy - 2,700sf) 6 158.00 948.00"); //this can probably just use some random combination of the randomizedItems array
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[5]/div/input", _rand.Next(1,150000).ToString()); //Weight
        }
        private void _equipmentRequirements() 
        {
            constructor.DropdownHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[1]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[2]"); // Equip Type - also made random
            constructor.TextboxHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[2]/div/input", _rand.Next(1, 75).ToString());
        }

        private void _distance()
        {
            constructor.DropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[1]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[1]/div/select/option[2]"); //Mileage engine - another one that should be randomized
            constructor.DropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select/option[2]"); //Method - randomize selection
        }

        private void _customerLH()
        {
            //this should do something in the future for more rigorous testing
        }

        private void _carrierTab()
        {
            constructor.ButtonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[3]/ul/li[3]/a");
            constructor.TextboxHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[2]/table[2]/tbody[3]/tr[8]/td[2]/input", _rand.Next(1, 2500).ToString()); //miles

            constructor.ButtonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr/td/center/div[2]/input");
            constructor.TextboxHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[2]/td/input", "ACME"); //carrier search
            System.Threading.Thread.Sleep(3000); //it's gotta load and it's slowwww - a wait that tells when this is loaded would be better but it's weird widget
            constructor.ButtonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[3]/td/select/option[1]");
            constructor.ButtonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[1]/td/input[4]");
            System.Threading.Thread.Sleep(500); //what a dumb popup
        }
    }
}
