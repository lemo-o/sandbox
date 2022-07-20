using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace Selenium
{
    //this should probably be changed to use inheritance (maybe an interface?) Proof of concept for now
    //This used to be two lists; one for textboxes and one for buttons.
    public class ComponentList
    {
        private List<(Components component, string input)> _currentComponentList { get; set; }
        public List<(Components component, string input)> CurrentComponentList
        {
            get { return _currentComponentList; }
            set { _currentComponentList = value; }
        }
        public ComponentList()
        {
            _currentComponentList = new List<(Components button, string input)>();
        }
    }
}
