Feature: Initial set up
	When I start up a system from scratch the system will ask me for some information as database location and administration password

@web
Scenario: Show database location selection screen if database location is missing
	Given I start up the system for the first time
	And the database location is not set		
	When I navigate to the default page
	Then I will be asked to enter the location of the database. Either I can select local and port number or a remote url and a port number.

@web
Scenario: Enter setup information correct
	Given I start up the system for the first time
	And the database location is not set
	And the administration password is not set
	And setup screen i showing
	When I select the default value local machine as database location, port 8080 as port 
	And I enter test as administration password
	And I click the save button
	Then the database location i saved as http://localhost:8080
	And administration password i saved as test	

@web
Scenario: Select remote machine as database location
	Given I start up the system for the first time
	And the database location is not set
	And the administration password is not set
	And setup screen i showing	
	When I select that my database is on a remote machine. I enter 127.0.0.1 as database location, port 8080 as port
	And I enter test as administration password
	And I click the save button
	Then the database location i saved as http://127.0.0.1:8080
	And administration password i saved as test	
