Feature: My Observatory App UI Tests

Scenario: Check tomorrow weather forecast from 9-day forecast screen
	Given I Launch the application
	And Agree to the T&C's on Disclaimer Screen
	And Agree to the T&C's on Policy Screen
	And Clicked OK to the Location Information Screen
	And Closed the What's new menu
	When I select the main hamburger menu
	And I scroll down to tap the 9-Day Forecast option
	Then I can see weather forecast for tomorrow's date
	And I can see the temperature forecast for tomorrow
	And I can see the humidity forecast for tomorrow
	And I can see a short description for tomorrow's weather