using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace seleniumtest
{
    class FirstCSClass
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver(); //Initialize

            driver.Navigate().GoToUrl("https://brokerage.qc.suntecktts.com/web/home");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            var username = driver.FindElement(By.Id("agent_login"));
            username.SendKeys("ben.hall");

            var password = driver.FindElement(By.Id("agent_password"));
            password.SendKeys("Qll2mm.08");
            password.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            var Loads = driver.FindElement(By.XPath("/html/body/header/nav/div/div/div[3]/ul/li[3]/a"));
            var createTL = driver.FindElement(By.XPath("/html/body/header/nav/div/div/div[3]/ul/li[3]/ul/li[2]/a"));

            Actions actions = new Actions(driver);

            actions.MoveToElement(Loads).Perform();
            createTL.Click();


            /*           var title = driver.Title;
                       Assert.AreEqual("Google", title);

                       driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

                       var searchBox = driver.FindElement(By.Name("q"));
                       var searchButton = driver.FindElement(By.Name("btnK"));

                       searchBox.SendKeys("Selenium");
                       searchButton.Click();

                       searchBox = driver.FindElement(By.Name("q"));
                       var value = searchBox.GetAttribute("value");
                       Assert.AreEqual("Selenium", value);

                       driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2500);
                       driver.Quit(); */
        }
    }
}