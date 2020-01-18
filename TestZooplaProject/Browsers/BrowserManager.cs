﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZooplaProject.Driver;
using WebDriverManager.DriverConfigs.Impl;

namespace TestZooplaProject.Browsers
{
    public class BrowserManager : Commons
    {
        private IWebDriver InitChromeDriver()
        {
            new WebDriverManager
                .DriverManager()
                .SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }

        private IWebDriver InitHeadlessChrome()
        {
            new WebDriverManager
                .DriverManager()
                .SetUpDriver(new ChromeConfig());

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-gpu", "--headless");

            return new ChromeDriver(options);
        }

        private IWebDriver InitFireFox()
        {
            new WebDriverManager
                .DriverManager()
                .SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }

        public void LaunchBrowser(string browser)
        {
            switch(browser)
            {
                case "Chrome":
                    _driver = InitChromeDriver();
                    break;
                case "Headless":
                    _driver = InitHeadlessChrome();
                    break;
                case "Firefox":
                    _driver = InitFireFox();
                    break;
                default:
                    _driver = InitHeadlessChrome();
                    break;
            }
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts()
                .ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts()
                .PageLoad = TimeSpan.FromSeconds(30);
        }

        public void CloseBrowser()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Quit();
        }
    }
}
