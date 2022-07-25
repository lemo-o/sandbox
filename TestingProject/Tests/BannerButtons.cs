using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class BannerButtons 
    {
        public BannerButtons(IBrowsers driver)
        {
            var banner = new Banner(driver);
            //for (int i = 1; i <= 7; i++) //Every header button
            //{
            //    banner.BannerButtons(i);
            //}
            for (int g = 1; g <= 7; g++)
            {
                for (int b = 1; b <= 20; b++)
                {
                    try
                    {
                        banner.BannerButtons(g, b);
                        banner.HomeNavigation();
                    }
                    catch
                    {
                        b = 1;
                        g++;
                        banner.BannerButtons(g, b);
                        banner.HomeNavigation();
                    }
                    finally
                    {
                        //test if correct page
                    }
                }
            }
        }
    }
}
