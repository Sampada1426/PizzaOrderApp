Feature: ConfirmOrder

Confirm the checked out order

@confirmorder
Scenario: Confirm order and go to confirmation page
	Given User is on the checkout page
	When User clicks on confirm order button
	Then User is redirected to confirmation page
