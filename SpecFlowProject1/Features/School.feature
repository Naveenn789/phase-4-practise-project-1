Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: verify Teacher data
	Given the list of Teacher data
	When the data is fetched
	Then the result of Teacher data should match

Scenario: verify Student data
	Given the list Student of data
	When the data is fetched
	Then the result of Student dta should match

Scenario: verify Subject data
	Given the list Subject of data
	When the data is fetched
	Then the result of Subject data should match