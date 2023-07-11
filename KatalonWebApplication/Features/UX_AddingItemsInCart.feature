Feature: UX_AddingItemsInCart

A short summary of the feature

@ShoppingCart
Scenario: 01_Adding items to the Shopping Cart
	Given I add four items to my cart
	When I view my cart
	Then I find total four items listed in my cart
	When I search for the lowest price item
	And I am able to remove the lowest price item from my cart
	Then I am able to verify three items in the cart