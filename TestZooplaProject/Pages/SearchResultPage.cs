using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZooplaProject.Pages
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement title;
        [FindsBy(How = How.CssSelector, Using = ".listing-results-price.text-price")]
        private IList<IWebElement> results;


        public void IsTitleDisplayedForProperty(string property, string location)
        {
            var titleText = title.Text;
            Assert.IsTrue(titleText.Contains(property));
            Assert.IsTrue(titleText.Contains(location));
        }

        public void IsResultDisplayed()
        {
            Assert.IsTrue(results.Count > 0);
        }

        public ProductDetailsPage ClickOnAnyResultsLink()
        {
            var random = new Random();
            var result = random.Next(0, results.Count - 1);
            results[result].Click();
            return new ProductDetailsPage(_driver);
        }
    }
}
