Feature: Show

A short summary of the feature

@showtag
Scenario: Working with Tables
	Given I input following numbers to the calculator
		| Numbers |
		| 20      |
		| 10      |
	When the two numbers are added
	Then I see the result and few more details
	| Results | Logo |
	| 120     | plus |
	Then the result should "PASSED"
