Feature: Login
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers
Then the result should be
Link to a feature: [Calculator](SpecFlowLoginProject.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Authentication
	Given the email is nikunj@gmail.com
	And the password is Nikunj@123
	When the email and password is matched
	Then result should be 1
