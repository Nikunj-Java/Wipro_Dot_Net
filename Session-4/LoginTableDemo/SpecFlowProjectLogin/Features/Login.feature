Feature: Login
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectLogin/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Authentication
	Given the email is nikunj@gmail.com
	And the password is Nikunj@123
	When user enter email and password
	| email            | password   |
	| nikunj@gmail.com | Nikunj@123 |
	| admin@gmail.com  | admin@123 |

	Then user authentication ends