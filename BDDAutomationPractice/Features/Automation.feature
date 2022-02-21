Feature: Automation
	verify the Shopping Workflow Automation 

@mytag
Scenario: Verify with correct username and correct password
	Given user navigate the url	
	When user search for the word "dress"
	And user click on the search button
	And user click on 'Sort By' drop down, choose 'Price: Lowest First' 
	And user Click on the ‘More’ Button
	And user Click 'Add to Cart' button 
	And user Take a screenshot of the product page
	And user Click on proceed to checkout
	And user in signin page Click Proceed to checkout 
	And user enter a registered email address
	And user enter a valid password
	And user click on signin button
	And user in address page, 'Click Proceed to checkout' 
	And user Click on Agree terms of service and Click 'Proceed to checkout' 
	And user Click on Confirm my order
	Then user click on signout button

