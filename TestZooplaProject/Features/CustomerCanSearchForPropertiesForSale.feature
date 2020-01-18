Feature: CustomerCanSearchForPropertiesForSale
	In order to know more about a property
	As a customer
	I want the ability search for a property for sale


Scenario Outline: Customer can search for any property
  Given I navigate to zoopla homepage
  When I enter a "<Location>" in the search text box
  And I select "<MinPrice>" from Min price dropdown
  And I select "<MaxPrice>" from Max price dropdown
  And I select "<Property>" from Property type dropdown
  And I select "<Bed>" from Bedrooms dropdown
  And I click on Search button
  Then a list of "<PropertyType>" in "<Location>" are displayed
  And I click on any of the results

Examples:
  |Location| MinPrice|MaxPrice|Property|Bed|PropertyType|
  |Manchester|£120,000|£230,000|Houses |3+ | Houses     |
  #|London    |£250,000|£400,000|Farms/land|No min| Property|
  #|Coventry|£120,000|£230,000|Flats |3+ | Flats     |
  #|Birmingham|         |       |      |   |           |
