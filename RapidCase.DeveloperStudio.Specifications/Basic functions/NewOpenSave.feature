Feature: New, Open and save
	The RapidCase Development Studio must have initial, save and open functionality for the configuration

@web
Scenario: A initial file is loaded the first time I start the RapidCase Development Studio
	Given It is the first time I start Developer studio	
	When I log in as Administrator
	Then a initial configuration will be loaded in to the RapidCase Development Studio

@web
Scenario: When a push the save button the active object is saved
	Given I'am loged in to the RapidCase Development Studio
	And I have made som changes
	When I press the save button
	Then my changes is saved to ?

@web
Scenario: When a log in to the RapidCase Development Studio the configuration is automaticly loaded
	Given it is not the first time I log in to the RapidCase Development Studio
	When I do a sussesful log in to the RapidCase Development Studio
	Then the configuration is loaded from ?
