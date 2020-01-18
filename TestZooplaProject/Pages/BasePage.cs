using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZooplaProject.Driver;

namespace TestZooplaProject.Pages
{
    public class BasePage : Commons
    {
        public string BASE_URL = "https://www.zoopla.co.uk/";
        public SelectElement select;

        public void LaunchUrl()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void SelectByText(IWebElement element, string text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }

        public void SelectByValue(IWebElement element, string value)
        {
            select = new SelectElement(element);
            select.SelectByText(value);
        }

        public void SelectByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }
    }
}
