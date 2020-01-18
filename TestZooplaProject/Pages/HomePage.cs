using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZooplaProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "search-input-location")]
        private IWebElement searchField;
        [FindsBy(How = How.Name, Using = "price_min")]
        private IWebElement minPrice;
        [FindsBy(How = How.Name, Using = "price_max")]
        private IWebElement maxPrice;
        [FindsBy(How = How.Name, Using = "property_type")]
        private IWebElement propertyType;
        [FindsBy(How = How.Name, Using = "beds_min")]
        private IWebElement noOfBeds;
        [FindsBy(How = How.Id, Using = "search-submit")]
        private IWebElement submitButton;

        

        public void EnterLocation(string location)
        {
            searchField.Clear();
            searchField.SendKeys(location);
        }

        public void SelectMiniPrice(string miniPrice)
        {
            SelectByText(minPrice, miniPrice);
        }

        public void SelectMaxiPrice(string maxiPrice)
        {
            SelectByText(maxPrice, maxiPrice);
        }

        public void SelectPropertyType(string property)
        {
            SelectByText(propertyType, property);
        }

        public void SelectNoOfBeds(string beds)
        {
            SelectByText(noOfBeds, beds);
        }

        public SearchResultPage ClickOnSubmitButton()
        {
            submitButton.Click();
            return new SearchResultPage(_driver);
        }
    }
}
