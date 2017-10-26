Feature: Greet
	In order to treated well
	As an end user
	I want to be greeted by the application

@GreetingFeature
Scenario: Greet with a name
	Given I have entered "John" into the Greet Dialog
	When I press Greet
	Then the result should be "Hello! John"
