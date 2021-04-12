Feature: Sign Up Sign up as an invited user via email
AS a user invited to join a community on 
Giftrete website I want to beable to accept the 
invitationSo that I can join andinteract with other
members with community

@SignUp
Scenario: Valid Sign up as an invited user via email
	Given a user navigate to giftrete by clicking on email invite "http://www.giftrete.com""
	When a user click on sign up Button
	And a user email address "nelytino91@yahoo.com"
	And a user first name "Nnenna"
	And a user enter last name "Ozioko"
	And a user phone number "07495712394"
	And a user enter password "Kamsi12£"
	And a user confirm password "Kamsi12£"
	And a user click on register
	Then sign in is displayed
	
	



	Scenario: Invalid-wrong email format
	Given a user navigate to giftrete by clicking on email invite "http://www.giftrete.com""
	When a user click on sign up Button
	And a user email address "nelytinoyahoo.com"
	And a user first name "Nnenna"
	And a user enter last name "Ozioko"
	And a user phone number "07495712394"
	And a user enter password "Kamsi12£"
	And a user confirm password "Kamsi12£"
	And a user click on register
	Then error message is displayed
	


Scenario: Invalid-wrong data on Name Field.
    Given a user navigate to giftrete by clicking on email invite "http://www.giftrete.com""
	When a user click on sign up Button
	And a user email address "nelytino@yahoo.com"
	And a user first name "123456"
	And a user enter last name "Ozioko"
	And a user phone number "07495712394"
	And a user enter password "Kamsi12£"
	And a user confirm password "Kamsi12£"
	And a user click on register
	Then Error is displayed
	



Scenario: Invalid Sign Up: No email address
   Given a user navigate to giftrete by clicking on email invite "http://www.giftrete.com""
	When a user click on sign up Button
	And a user email address ""
	And a user first name "Nnenna"
	And a user enter last name "Ozioko"
	And a user phone number "07495712394"
	And a user enter password "Kamsi12£"
	And a user confirm password "Kamsi12£"
	And a user click on register
	Then The Email Address field is required is displayed.
	



Scenario: nvalid Sign UP: To verify that a user cannot create account with invalid mobile number
    Given a user navigate to giftrete by clicking on email invite "http://www.giftrete.com""
	When a user click on sign up Button
	And a user email address "nelytinoyahoo.com"
	And a user first name "Nnenna"
	And a user enter last name "Ozioko"
	And a user phone number "07495712394"
	And a user enter password "Kamsi12£"
	And a user confirm password "Kamsi12£"
	And a user click on register
	#Then error message is displayed
	#Then GiftRete Logo is displayed


