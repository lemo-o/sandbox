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
        private TextBoxList textboxes = new TextBoxList();
        private ButtonList buttons = new ButtonList();

        public CreateTL(IBrowsers driver) : base(driver)
        {
            for (int i = 0; i < elements[0].Length; i++)
            {
                buttons.CurrentButtonList.Add((new Button(driver, elements[0][i]), "")); //since the LINQ idea isn't working, it's easiest to leave the string field blank
            }
            for (int i = 0; i < elements[1].Length; i++)
            {
                textboxes.CurrentTextboxList.Add((new Textbox(driver, elements[1][i]), ""));
            }
        }

        //I believe this whole situation can be avoided in at least 3 different ways. Best way would be to get LINQ working
        private void tooMuchTyping(int listSelect, int listIndex, string inputPassthrough) //0 for clicks, 1 for textboxes
        {
            switch(listSelect)
            {
                case 0:
                    buttons.CurrentButtonList[listIndex].button.Click();
                    buttons.CurrentButtonList[listIndex+1].button.Click();
                    break;
                case 1:
                    textboxes.CurrentTextboxList[listIndex].textbox.SendKeys(inputPassthrough);
                    break;
            };
        }
        public void CustomerField() => tooMuchTyping(0, 0, "");

        public void ShipperName(string input) => tooMuchTyping(1, 0, input);
        public void ShipperAddress1(string input) => tooMuchTyping(1,1,input); //
        public void ShipperAddress2(string input) => tooMuchTyping(1, 2, input);
        public void ShipperZIP(string input) => tooMuchTyping(1, 5, input);
        public void ShipperEarliestDate(string input) => tooMuchTyping(1, 6, input);
        public void ConsigneeName(string input) => tooMuchTyping(1, 7, input);
        public void ConsigneeAddress1(string input) => tooMuchTyping(1, 8, input);
        public void ConsigneeAddress2(string input) => tooMuchTyping(1, 9, input);
        public void ConsigneeZIP (string input) => tooMuchTyping(1, 12, input);
        public void ConsigneeEarliestDate(string input) => tooMuchTyping(1, 13, input);
        public void Quantity(string input) => tooMuchTyping(1, 14, input);
        public void UnitOfMeasurement() => tooMuchTyping(0, 2, "");
        public void Description(string input) => tooMuchTyping(1, 15, input);
        public void EquipmentType() => tooMuchTyping(0, 4, "");
        public void Weight(string input) => tooMuchTyping(1, 16, input);
        public void MileageEngine() => buttons.CurrentButtonList[7].button.Click();
        public void Method() => buttons.CurrentButtonList[9].button.Click();
        public void CreateLoadButton() => buttons.CurrentButtonList[10].button.Click();



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
