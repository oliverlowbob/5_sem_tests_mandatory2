Feature: Order

Scenario: Order two iPhone 8
	Given the model ordered is an iPhone 8
	And the quantity is 2
	When the order is made
	Then an order containing model iPhone 8 and quantity 2