﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GiftreteCommunity.Hooks
{
    [Binding]
    public class WebHooks
    {
        public static IWebDriver driver;

        
        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
