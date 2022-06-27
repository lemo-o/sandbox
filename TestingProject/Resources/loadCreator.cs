using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace seleniumTest
{
    public class loadCreator
    {

        generalHandlers constructor = new generalHandlers();
        Random rand = new Random();

        public loadCreator() { }

        public void changethisname() //this entire section needs to get moved into functions
        {
            navigation();
            customer();
            shipper();
            consignee();
            shipmentCommodity();
            equipmentRequirements();
            distance();
            constructor.buttonHandler("/html/body/div[2]/div[2]/form/div[9]/div/div/div[3]/button"); //submit
            carrierTab();
            constructor.buttonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[1]/table/tbody/tr/td[2]/div/input[6]");

        }

        private void navigation() 
        {
            constructor.browserStart("https://brokerage.qc.suntecktts.com/agents/login");
            constructor.loginPage("ben.hall", "Qll2mm.08");

            constructor.dropdownHandler("/html/body/header/nav/div/div/div[3]/ul/li[3]/a", "/html/body/header/nav/div/div/div[3]/ul/li[3]/ul/li[2]/a"); 
        }

        private void customer() 
        {
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[2]/div[2]/div/div[1]/div[1]/div/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[3]");
        }

        private void shipper() 
        {
            locationDefinitions temp_definitions = new locationDefinitions();
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[2]/div/input", temp_definitions.randomizedItems[0]); //name
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[3]/div/input", temp_definitions.randomizedItems[1]); //Address
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[6]/div/div/span[2]/input", temp_definitions.randomizedItems[3]); //ZIP
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[13]/div[1]/div/input", DateTime.Now.ToString("M/d/yyyy")); //Earliest Date
        }

        private void consignee() 
        {
            locationDefinitions temp_definitions = new locationDefinitions();
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[2]/div/input", temp_definitions.randomizedItems[0]); //name
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[3]/div/input", temp_definitions.randomizedItems[1]); //Address
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[6]/div/div/span[2]/input", temp_definitions.randomizedItems[3]); //ZIP
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[13]/div[1]/div/input", DateTime.Now.ToString("M/d/yyyy"));
        }

        private void shipmentCommodity() 
        {
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[2]/div/input", rand.Next(1, 25).ToString()); //quantity
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[3]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); // UoM this should be made random
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[4]/div/input", "placeholder text"); //this can probably just use some random combination of the randomizedItems array
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[5]/div/input", rand.Next(1,150000).ToString()); //Weight
        }
        private void equipmentRequirements() 
        {
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[1]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[2]"); // Equip Type - also made random
            constructor.textboxHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[2]/div/input", rand.Next(1, 75).ToString());
        }

        private void distance()
        {
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[1]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[1]/div/select/option[2]"); //Mileage engine - another one that should be randomized
            constructor.dropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select/option[2]"); //Method - randomize selection
        }

        private void custLH_and_Fuel()
        {
            //this should do something in the future for more rigorous testing
        }

        private void carrierTab()
        {
            constructor.buttonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[3]/ul/li[3]/a");
            constructor.textboxHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[2]/table[2]/tbody[3]/tr[8]/td[2]/input", rand.Next(1, 2500).ToString()); //miles

            constructor.buttonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr/td/center/div[2]/input");
            constructor.textboxHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[2]/td/input", "ACME");
            System.Threading.Thread.Sleep(3000); //it's gotta load and it's slowwww - a wait that tells when this is loaded would be better but it's weird widget
            constructor.buttonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[3]/td/select/option[1]");
            constructor.buttonHandler("/html/body/div[4]/table/tbody/tr/td/form/div[5]/div[8]/div/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div[3]/table/tbody/tr[1]/td/input[4]");
            System.Threading.Thread.Sleep(500); //what a dumb popup
        }
    }
}
