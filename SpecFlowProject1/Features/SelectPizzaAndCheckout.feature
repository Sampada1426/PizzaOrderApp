Feature: Select a Pizza and Checkout

Select a pizza and quantity and then checkout pizza

@CheckoutPizza
Scenario: Select a pizza and checkout
	Given User is on the homepage
	When User selects pizza with Id "PizzaId_{1}" by clicking radio button
	Then User clicks on checkout button
