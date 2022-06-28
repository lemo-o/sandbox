using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
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
            _findElement = new Driver().FindElement();
            //_findElement = new Chrome.Driver().FindElement();
        }

        public override object FindElement()
        {
            return _findElement;
        }
    }
}