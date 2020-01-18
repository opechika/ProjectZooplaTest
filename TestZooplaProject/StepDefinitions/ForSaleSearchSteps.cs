using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestZooplaProject.Pages;

namespace TestZooplaProject.StepDefinitions
{
    [Binding]
    public sealed class ForSaleSearchSteps : BasePage
    {

        HomePage homepage = new HomePage(_driver);
        SearchResultPage searchResultPage = new SearchResultPage(_driver);
        ProductDetailsPage productDetailsPage = new ProductDetailsPage(_driver);

        [Given(@"I navigate to zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            homepage.LaunchUrl();
        }

        [When(@"I enter a ""(.*)"" in the search text box")]
        public void WhenIEnterAInTheSearchTextBox(string location)
        {
            homepage.EnterLocation(location);
        }

        [When(@"I select ""(.*)"" from Min price dropdown")]
        public void WhenISelectFromMinPriceDropdown(string miniPrice)
        {
            homepage.SelectMiniPrice(miniPrice);
        }

        [When(@"I select ""(.*)"" from Max price dropdown")]
        public void WhenISelectFromMaxPriceDropdown(string maxiPrice)
        {
            homepage.SelectMaxiPrice(maxiPrice);
        }

        [When(@"I select ""(.*)"" from Property type dropdown")]
        public void WhenISelectFromPropertyTypeDropdown(string property)
        {
            homepage.SelectPropertyType(property);
        }

        [When(@"I select ""(.*)"" from Bedrooms dropdown")]
        public void WhenISelectFromBedroomsDropdown(string bed)
        {
            homepage.SelectNoOfBeds(bed);
        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            searchResultPage = homepage.ClickOnSubmitButton();
        }

        [Then(@"a list of ""(.*)"" in ""(.*)"" are displayed")]
        public void ThenAListOfInAreDisplayed(string property, string location)
        {
            searchResultPage
                .IsTitleDisplayedForProperty(property, location);
        }

        [Then(@"I click on any of the results")]
        public void ThenIClickOnAnyOfTheResults()
        {
            productDetailsPage = searchResultPage.ClickOnAnyResultsLink();
        }

    }
}
