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
    public class ButtonList
    {
        private List<(Button button, string input)> _currentButtonList { get; set; }
        public List<(Button button, string input)> CurrentButtonList
        {
            get { return _currentButtonList; }
            set { _currentButtonList = value; }
        }
        public ButtonList()
        {
            _currentButtonList = new List<(Button button, string input)>();
        }
    }
    public class TextBoxList
    {
        private List<(Textbox textbox, string input)> _currentTextboxList { get; set; }
        public List<(Textbox textbox, string input)> CurrentTextboxList
        {
            get { return _currentTextboxList; }
            set { _currentTextboxList = value; }
        }
        public TextBoxList()
        {
            _currentTextboxList = new List<(Textbox textbox, string input)>();
        }
    }
}
