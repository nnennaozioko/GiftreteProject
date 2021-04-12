Feature: MyCommunities
AS a registered user on Giftrete website (www.giftrete.com)
I want to create a community
So that members can interact on the platform

@mytag
Scenario: Valid: To verify if a user can create community from my communities menu items.
	Given a user navigate as a registered user to "https://www.giftrete.com/"
	When a user click the sign in button
	And a user enter emall address "nelytino@yahoo.com"
	And a user enter Password "Kamsi12£"
	And a user tick remember me box
	And a user click login button
	And a user click  mycommunities
	And a user click create community
	And a user enter community name "Woman Squad"
	And a user enter community handle "Women_squad"
	And a user enter location address "23 tenby road, Romford"
	And a user enter category "Education"
	#And a user select category from dropdown
	And a user choose file "\WomenSquad.jpg"
	#And a user browse to upload image "\WomenSquad.jpg"
	And a user tick to select membership type
	And a user enter community website link "https://www.giftrete.com/"
	#And a user click on community descrition
	And a user click and enter community description "wommen"
	And a user enters community description "this is a test community"
	And a user click on create community
	Then a user created community