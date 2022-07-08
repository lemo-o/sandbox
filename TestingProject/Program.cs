using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
namespace Selenium
{
    class Working
    {
        static void Main(string[] args)
        {
            var Login = new Login();
            Login.LoginPage();
        }
    }
}