using AssertLibrary;
using GiftreteCommunity.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GiftreteCommunity.Steps
{
    [Binding]
    public class MyCommunitiesSteps
    {
        MyCommunitiesPage myCommunitiesPage = new MyCommunitiesPage();

        [Given(@"a user navigate as a registered user to ""(.*)""")]
        public void GivenAUserNavigateAsARegisteredUserTo(string url)
        {
            myCommunitiesPage.Navigate(url);
        }
        
        [When(@"a user click the sign in button")]
        public void WhenAUserClickTheSignInButton()
        {
            myCommunitiesPage.SignIn();
        }
        
        [When(@"a user enter emall address ""(.*)""")]
        public void WhenAUserEnterEmallAddress(string email)
        {
            myCommunitiesPage.EmailAddress(email);

        }
        
        [When(@"a user enter Password ""(.*)""")]
        public void WhenAUserEnterPassword(string passwordtxt)
        {
            myCommunitiesPage.PassWord(passwordtxt);
        }
        
        [When(@"a user tick remember me box")]
        public void WhenAUserTickRememberMeBox()
        {
            myCommunitiesPage.RememberMeBox();
        }
        
        [When(@"a user click login button")]
        public void WhenAUserClickLoginButton()
        {
            myCommunitiesPage.LoginButton();
        }
        
        [When(@"a user click  mycommunities")]
        public void WhenAUserClickMycommunities()
        {
            Thread.Sleep(5000);
            myCommunitiesPage.MyCommunities();
        }
        
        [When(@"a user click create community")]
        public void WhenAUserClickCreateCommunity()
        {
            myCommunitiesPage.CreateCommunity();
        }
        
        [When(@"a user enter community name ""(.*)""")]
        public void WhenAUserEnterCommunityName(string name)
        {
            myCommunitiesPage.CommunityName(name);
        }
        
        [When(@"a user enter community handle ""(.*)""")]
        public void WhenAUserEnterCommunityHandle(string communityHandle)
        {
            myCommunitiesPage.CommunityHandle(communityHandle);
        }
        
        [When(@"a user enter location address ""(.*)""")]
        public void WhenAUserEnterLocationAddress(string Addresstxt)
        {
            myCommunitiesPage.LocationAddress(Addresstxt);
        }
        [When(@"a user enter category ""(.*)""")]
        public void WhenAUserEnterCategory(string categorytext)
        {
            myCommunitiesPage.Category(categorytext);
        }

        [When(@"a user choose file ""(.*)""")]
        public void WhenAUserChooseFile(string file)
        {
            Thread.Sleep(5000);
            myCommunitiesPage.ChooseFile(file);
            
        }

        [When(@"a user tick to select membership type")]
        public void WhenAUserTickToSelectMembershipType()
        {
            myCommunitiesPage.MembershipeType(); 
        }
        
        [When(@"a user enter community website link ""(.*)""")]
        public void WhenAUserEnterCommunityWebsiteLink(string websitetxt)
        {
            myCommunitiesPage.CommunityWebsite(websitetxt); 
        }
        //[When(@"a user click on community descrition")]
        //public void WhenAUserClickOnCommunityDescrition()
        //{
        //    myCommunitiesPage.Community();
        //}


        //[When(@"a user enters community description ""(.*)""")]
        //public void WhenAUserEntersCommunityDescription(string communityText)
        //{
        //    myCommunitiesPage.CommunityDescription(communityText);
        //}
        [When(@"a user click and enter community description ""(.*)""")]
        public void WhenAUserClickAndEnterCommunityDescription(string txt)
        {
            myCommunitiesPage.Community();
            myCommunitiesPage.CommunityDescription(txt);
        }




        [When(@"a user click on create community")]
        public void WhenAUserClickOnCreateCommunity()
        {
            myCommunitiesPage.CreateCommunityButton();
        }
        
        [Then(@"a user created community")]
        public void ThenAUserCreatedCommunity()
        {

          //Assert.IsTrue(myCommunitiesPage.HomeIconDisplayed());
        }
    }
}
