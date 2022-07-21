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
        public CreateTL(IBrowsers driver) : base(driver) { }

        public void Navigation() => driver.CurrentDriver().Navigate().GoToUrl(Constants.URLs[3]);
        public void CustomerFieldButton()
        {
            Components _component = new Components(driver, By.XPath("//div[2]//div[2]/div[2]//div[1]/div[1]/div/div/span/span[1]//span[2]"));
            _component.Click();
            _component = new Components(driver, By.XPath("//span[2]//li[2]"));
            _component.Click();
        }
        public void ShipperName(string input) 
        {
            Components _component = new Components(driver, By.Id("form_shipper_name"));
            _component.SendKeys(input);
        }
        public void ShipperAddress1(string input) 
        {
            Components _component = new Components(driver, By.Id("form_shipper_address"));
            _component.SendKeys(input);
        }
        public void ShipperAddress2(string input) 
        {
            Components _component = new Components(driver, By.Id("form_shipper_address2"));
            _component.SendKeys(input);
        }
        public void ShipperZIP(string input) 
        {
            Components _component = new Components(driver, By.XPath("//div[1]/div/div/div[6]//span[2]/input"));
            _component.SendKeys(input);
        }
        public void ShipperEarliestDate(string input) //=> tooMuchTyping(1, 6, );
        {
            Components _component = new Components(driver, By.Id("form_shipper_earliest_date"));
            _component.SendKeys(input);
        }
        public void ConsigneeName(string input) //=> tooMuchTyping(1, 7, );
        {
            Components _component = new Components(driver, By.Id("form_consignee_name"));
            _component.SendKeys(input);
        }
        public void ConsigneeAddress1(string input)
        {
            Components _component = new Components(driver, By.Id("form_consignee_address"));
            _component.SendKeys(input);
        }
        public void ConsigneeAddress2(string input)
        {
            Components _component = new Components(driver, By.Id("form_consignee_address2"));
            _component.SendKeys(input);
        }
        public void ConsigneeZIP(string input) 
        {
            Components _component = new Components(driver, By.XPath("//div[2]/div/div/div[6]//span[2]/input"));
            _component.SendKeys(input);
        }
        public void ConsigneeEarliestDate(string input) 
        {
            Components _component = new Components(driver, By.Id("form_consignee_earliest_date"));
            _component.SendKeys(input);
        }
        public void Quantity(string input)
        {
            Components _component = new Components(driver, By.Id("form_items_1_quantity"));
            _component.SendKeys(input);
        }
        public void UnitOfMeasurement() 
        {
            Components _component = new Components(driver, By.XPath("//div[4]//div[3]/div/span/span[1]/span"));
            _component.Click();
            _component = new Components(driver, By.XPath("//span[2]//span[2]/ul/li[4]"));
            _component.Click();
        }
        public void Description(string input) 
        {
            Components _component = new Components(driver, By.Id("form_items_1_description"));
            _component.SendKeys(input);
        }
        public void EquipmentType()
        {
            Components _component = new Components(driver, By.XPath("//div[2]//div[5]//div[1]/div/span/span[1]/span"));
            _component.Click();
            _component = new Components(driver, By.XPath("//span[2]/span//ul/li[1]"));
            _component.Click();
        }
        public void Weight(string input) 
        {
            Components _component = new Components(driver, By.Id("form_items_1_weight"));
            _component.SendKeys(input);
        }
        public void MileageEngine(int input) 
        {
            Components _component = new Components(driver, By.XPath($"//div[6]/div[2]//div[1]/div/select/option[{input+2}]")); 
            _component.Click();
        }
        public void Method(int input)  //0 is practical, 1 is shortest, 2 is national
        {
            Components _component = new Components(driver, By.XPath($"//div[6]//div[2]/div/select/option[{input + 2}]"));
            _component.Click();
        }
        public void CreateLoadButton() 
        {
            Components _component = new Components(driver, By.Id("form_submit"));
            _component.Click();
        }
    }
}
