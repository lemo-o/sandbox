using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace Selenium
{
    public class CreateTL : BaseComponent
    {
        private ComponentList _components = new ComponentList();
        private int _index; 
        public CreateTL(IBrowsers driver) : base(driver)
        {
            for (int i = 0; i < elements[0].Length; i++) //fills with the first bank of elements[][], which is all the button elements which require clicking
            {
                _components.CurrentComponentList.Add((new Components(driver, elements[0][i]), "")); //since the LINQ idea isn't working, it's easiest to leave the string field blank
            }
            _index = elements[0].Length; //it is technically faster to just index the arraylength rather than measuring the length each time
            for (int i = 0; i < elements[1].Length; i++) //fills with the first bank of elements[][], which is all the textbox elements which require text
            {
                _components.CurrentComponentList.Add((new Components(driver, elements[1][i]), ""));
            }
        }
        private List<string> _randomList = new List<string>();

        //I believe this whole situation can be avoided in at least 3 different ways. Best way would be to get LINQ working
        private void tooMuchTyping(int listSelect, int listIndex, string inputPassthrough) //0 for clicks, 1 for textboxes
        {
            switch(listSelect)
            {
                case 0:
                    _components.CurrentComponentList[listIndex].component.Click();
                    _components.CurrentComponentList[listIndex+1].component.Click();
                    break;
                case 1:
                    _components.CurrentComponentList[listIndex+_index].component.SendKeys(inputPassthrough);
                    break;
            };
        }

        Random rand = new Random();
        public void Navigation() => driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[3]);
        public void CustomerField() => tooMuchTyping(0, 0, "");
        public void ShipperName() => tooMuchTyping(1, 0, Constants.Names[rand.Next(0, Constants.Names.Length)]);
        public void ShipperAddress1() => tooMuchTyping(1,1, Constants.Address1[rand.Next(0, Constants.Address1.Length)]); 
        public void ShipperAddress2() => tooMuchTyping(1, 2, Constants.Address2[rand.Next(0, Constants.Address2.Length)]);
        public void ShipperZIP() => tooMuchTyping(1, 5, Constants.CityBlocks[rand.Next(0, 1)][5]);
        public void ShipperEarliestDate() => tooMuchTyping(1, 6, DateTime.Now.ToString("M/d/yyyy"));
        public void ConsigneeName() => tooMuchTyping(1, 7, Constants.Names[rand.Next(0, Constants.Names.Length)]);
        public void ConsigneeAddress1() => tooMuchTyping(1, 8, Constants.Address1[rand.Next(0, Constants.Address1.Length)]);
        public void ConsigneeAddress2() => tooMuchTyping(1, 9, Constants.Address2[rand.Next(0, Constants.Address2.Length)]);
        public void ConsigneeZIP () => tooMuchTyping(1, 12, Constants.CityBlocks[rand.Next(0, 1)][5]);
        public void ConsigneeEarliestDate() => tooMuchTyping(1, 13, DateTime.Now.ToString("M/d/yyyy"));
        public void Quantity() => tooMuchTyping(1, 14, rand.Next(0,10).ToString());
        public void UnitOfMeasurement() => tooMuchTyping(0, 2, "");
        public void Description() => tooMuchTyping(1, 15, "stuff");
        public void EquipmentType() => tooMuchTyping(0, 4, "");
        public void Weight() => tooMuchTyping(1, 16, rand.Next(0, 150000).ToString());
        public void MileageEngine() => _components.CurrentComponentList[7].component.Click();
        public void Method() => _components.CurrentComponentList[9].component.Click();
        public void CreateLoadButton() => _components.CurrentComponentList[10].component.Click();



        //So I used this the first time; and it kinda just worked well using a for loop to fill out all the buttons I needed
        //Maybe a smarter way to do this would to actually have some sorting going on e.g. using a jagged array, or just multiple arrays for whether it's a button or a textbox
        private static readonly By[][] elements =
        {
            //button elements
            new By[]{
                By.XPath("//div[2]//div[2]/div[2]//div[1]/div[1]/div/div/span/span[1]//span[2]"),                //|0       
                By.XPath("//span[2]//li[2]"),                                   //Customer                         |1
                By.XPath("//div[4]//div[3]/div/span/span[1]/span"),             // UoM                             |2
                By.XPath("//span[2]//span[2]/ul/li[4]"),                        // UoM Second Click                |3
                By.XPath("//div[2]//div[5]//div[1]/div/span/span[1]/span"),     // Equipment type, first click     |4
                By.XPath("//span[2]/span//ul/li[1]"),                           // Equpment type, second click     |5
                By.Id("form_carriers_1_mileage_engine"),                        // Mileage engine, first click     |6
                By.XPath("//div[6]/div[2]/div/div[1]//option[2]"),              // Mileage engine, second click    |7
                By.XPath("//div[2]//div[6]/div[2]//div[2]//option[2]"),         // Method, first click             |8
                By.XPath("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select/option[3]"),              // Method, second                  |9
                By.Id("form_submit")                                            // Create Load Button              |10
            },
            //textbox elements
            new By[]{
                By.Id("form_shipper_name"),                                     // Shipper name                    |0
                By.Id("form_shipper_address"),                                  // Address1                        |1
                By.Id("form_shipper_address2"),                                 // Address2                        |2
                By.Id("form_shipper_city"),                                     // City                            |3
                By.Id(""),                                                      // State                           |4
                By.XPath("//div[1]/div/div/div[6]/div/div/span[2]/input"),      // ZIP                             |5
                By.Id("form_shipper_earliest_date"),                            // Earliest Date                   |6
                                                                                                                   
                By.Id("form_consignee_name"),                                   // Consignee name                  |7
                By.Id("form_consignee_address"),                                // Address1                        |8
                By.Id("form_consignee_address2"),                               // Address2                        |9
                By.Id("form_consignee_city"),                                   // City                            |10
                By.Id(""),                                                      // State                           |11
                By.XPath("//div[2]/div/div/div[6]/div/div/span[2]/input"),      // ZIP                             |12
                By.Id("form_consignee_earliest_date"),                          // Earliest date; consignee        |13        
                By.Id("form_items_1_quantity"),                                 // Qty                             |14
                By.Id("form_items_1_description"),                              // Description                     |15
                By.Id("form_items_1_weight")                                    // Weight                          |16
            }
        };
    }
}
