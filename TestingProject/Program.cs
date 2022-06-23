using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace seleniumtest
{
    class FirstCSClass
    {
        public static ChromeDriver driver;
        static void browserStart(string temp) //also navigates to page
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(temp);
            driver.Manage().Window.Maximize();
          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }
        static void dropdownHandler(string x, string y /*, string l2, string l3 */) //input the xml for a dropdown and their respective codes 
        {
            Actions action = new Actions(driver);

            var dropdown = driver.FindElement(By.XPath(x));

            action.MoveToElement(dropdown).Perform(); //xpath doesn't work for something reason? use the id - ID doesn't work? It's probably a clicking box; therefore, click the box, then check for xpath again
            try
            {
                var level_1 = driver.FindElement(By.XPath(y));
                level_1.Click();
            }
            catch
            {
                try
                {
                    var level_1 = driver.FindElement(By.Id(y));
                    level_1.Click();
                }
                catch
                {
                    dropdown.Click();
                    var level_1 = driver.FindElement(By.XPath(y));
                    level_1.Click();
                }
            }

            /* Logic for this should be:
             * Check what is the "lowest" level entered
             * Navigate to the one before that level
             * Click on the lowest level
             */

            //this will probably need a pretty good waiting strategy. As of now, I wait implicitly in the main section of the code
        }
        static void textboxHandler(string location, string text) //this section needs errorchecking
        {
            var temp = driver.FindElement(By.XPath(location));
            temp.SendKeys(text);
        }
        static void loginPage(string login, string pw) //this can 100% be cleverer - current it's not "generalized" Past that, it lacks errorchecking
        {
            var username = driver.FindElement(By.XPath("//*[@id='agent_login']"));
            username.SendKeys(login);

            var password = driver.FindElement(By.XPath("//*[@id='agent_password']"));
            password.SendKeys(pw);

            password.Submit();
        }
        static void Main(string[] args)
        {

            

            browserStart("https://brokerage.qc.suntecktts.com/agents/login");
            loginPage("-", "-");
            dropdownHandler("/html/body/header/nav/div/div/div[3]/ul/li[3]", "/html/body/header/nav/div/div/div[3]/ul/li[3]/ul/li[2]/a"); //navigation to the CreateTL form
            dropdownHandler("/html/body/div[2]/div[2]/form/div[2]/div[2]/div/div[1]/div[1]/div/div/span/span[1]/span/span[2]", "/html/body/span[2]/span/span[2]/ul/li[2]");

            
            dropdownHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[1]/div/span/span[1]/span/span[1]", "/html/body/span[2]/span/span[2]/ul/li"); //Fill the information manually using the textboxHandler - this is a "hacky" solution
            dropdownHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[1]/div/span/span[1]/span/span[1]", "/html/body/span[2]/span/span[2]/ul/li"); //consignnee
            textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[1]/div/div/div[13]/div[1]/div/input", "6/24/2022"); //this should ideally use a function of Time
            textboxHandler("/html/body/div[2]/div[2]/form/div[3]/div[2]/div/div[2]/div/div/div[13]/div[1]/div/input", "6/24/2022"); //this too
            
            textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[2]/div/input", "1"); //quantity, should be random, from 1-10000
            dropdownHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[3]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); //UoM, should be randomized for what is available in the dropdown
            textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[4]/div/input", "1"); //Description, should fill with random garbage
            textboxHandler("/html/body/div[2]/div[2]/form/div[4]/div[2]/div/div/div[1]/div[5]/div/input", "1"); //Weight, should fill with a random value 1-150,000

            dropdownHandler("/html/body/div[2]/div[2]/form/div[5]/div[2]/div/div[1]/div/span/span[1]/span", "/html/body/span[2]/span/span[2]/ul/li[1]"); //Equipment Type

            dropdownHandler("/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select", "/html/body/div[2]/div[2]/form/div[6]/div[2]/div/div[2]/div/select/option[2]"); //Method



        }

    }
}