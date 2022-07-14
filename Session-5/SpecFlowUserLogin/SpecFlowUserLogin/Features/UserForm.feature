Feature: UserForm
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowUserLogin/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Login as Admin again
	Given I have loaded the webpage again
	And I have entere userid and password again
	| userid   | password   |
	| myuserid | mypassword |
	And I click login
	And I fill in the message form with data again
	| title            | Message            |
	| Title of the day | Message of the day |
	Then I click submit button again