Feature: Transunion Home Page
	
	In order to learn my Credit score information
	As a Transunion Customer
	I want to view the Transunion Home Page

Background: Navigate to the Transunion.com Home Page
	Given I navigate to the "http://www.Transunion.com" Home Page

@Smoke
Scenario Outline: View Home Page as Full Page
	Given the Transunion Home Page is a certain <Browser Size> 
	When the Base Home Page Image is Compared to the Current Home Page Image
	Then the Home Page Images should match the proper <Browser Size> 

Examples:

| Browser Size |
| Full         |
| Half         |
| Mobile       |

