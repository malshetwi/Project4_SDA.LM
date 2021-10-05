Feature: TestOrder

@ToDoApp	
Scenario: Test ordering Pizza
	Given I open URL
	And I Press on fourth pizza
	When I Confirm
	Then I verify order submited