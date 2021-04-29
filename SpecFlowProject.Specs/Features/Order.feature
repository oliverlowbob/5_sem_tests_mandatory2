Feature: Order
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Order two iPhone 8
	Given the model ordered is an iPhone 8
	And the quantity is 2
	When the order is made
	Then an order containing model iPhone 8 and quantity 2