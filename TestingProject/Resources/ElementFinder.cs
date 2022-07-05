using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium //I don't think this file actually does anything anymore. Taught me abstracts though!
{
    abstract class ElementFinder
    {
        public abstract object FindElement(); //i have no idea if this is correct
    }

    class ChromeFinder : ElementFinder //does it need to be chrome? I don't ~think~ so
    {
        private object _findElement;
        
        public ChromeFinder()
        {
            _findElement = Chrome.Driver().FindElement(By.XPath("sample")); //how do you pass the stuff thru?
        }

        public override object FindElement()
        {
            return _findElement;
        }
    }
}