Feature: Facebook
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBDDSelenium/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Facebook Should be able to logged in me
	Given I have navigated to facebook page
	And I have entered nikunj@gmail.com as email keyword
	And I have entered Nikunj@123 as password keyword
	When I press the login button
	Then then i will be abled to logged in