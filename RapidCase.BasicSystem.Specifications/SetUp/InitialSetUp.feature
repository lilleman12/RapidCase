Feature: Initial set up
	When I start up a system from scratch the system will ask me for some information as database location and administration password

Scenario: Show database location selection screen if database location is missing
	Given I start up the system for the first time
	And the database location is not set		
	When I navigate to the default page
	Then I will be asked to enter the location of the database. Either I can select local and port number or a remote url and a port number.

Scenario: Select local machine as database location
	Given I start up the system for the first time
	And database location selection screen i showing
	When I select local machine as database location, port 8080 as port and clicked save button
	Then the database location i saved as http://localhost:8080

Scenario: Select remote machine as database location
	Given I start up the system for the first time
	And database location selection screen i showing
	When I select that my database is on a remote machine. I enter 192.168.0.1 as database location, port 8080 as port and clicked save button
	Then the database location i saved as http://192.168.0.1:8080

Scenario: Request password for administrator if it do not exist
	Given Administrator do not have a password	
	When I navigate to the default page
	Then I be shown a password field to enter a new password and a button to submit it

Scenario: Enter a new password for the administrator
	Given Administrator do not have a password
	And I have navigated to the default page
	And I am requested to enter a password for the administrator
	When I enter test123 as password and click the submit button
	Then test123 will be saved as the password for the administrator and navigated to RapidCase Development Studio