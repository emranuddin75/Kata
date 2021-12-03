Feature: AlphabetDiamond
	As a user
	I want to create a diamond by suppling only a center point letter

@AlphabetDiamond
Scenario: Create a Diamond With Not a Letter
	Given Center Supplied Character Is Not a Letter
	When Diamond is Created
	Then the Output for A should be Empty

Scenario: Create a Diamond With Letter A
	Given Center Supplied Letter Is A
	When Diamond is Created
	Then the Output for A should be A

Scenario: Create a Diamond With Any Letter Other A
	Given Center Supplied Letter Not A Is Z
	When Diamond is Created
	Then the Output for Z should form a Diamond
	And Diamond should Contain One instance of A at Start Point
	And Diamond should Contain One instance of A at End Point
	And Diamond Should Contain One line for Center Point as Z
	And Diamond Should Contain Two instance of a Letter on Each Line Not A
	And Diamond Should Contain Two instance of Matching Lines For Each Non Center Letter



