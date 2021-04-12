using AssertLibrary;
using FluentAssertions;
using GiftreteCommunity.Hooks;
using GiftreteCommunity.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace GiftreteCommunity.Steps
{
    [Binding]
    public class SignUpSteps
    {
        // public IWebDriver driver = WebHooks.driver;

        SignUpPage signUpPage = new SignUpPage();
        
                
        [Given(@"a user navigate to giftrete by clicking on email invite ""(.*)""""")]
        public void GivenAUserNavigateToGiftreteByClickingOnEmailInvite(string url)
        {
            signUpPage.Navigate(url);
        }

     

        [When(@"a user click on sign up Button")]
        public void WhenAUserClickOnSignUpButton()
        {
            signUpPage.ClickSignUp();
        }


        [When(@"a user email address ""(.*)""")]
        public void WhenAUserEmailAddress(string email)
        {
            signUpPage.EnterEmail(email);
        }
        
        [When(@"a user first name ""(.*)""")]
        public void WhenAUserFirstName(string firstName)
        {
            signUpPage.EnterFirstName(firstName);
        }
        
        [When(@"a user enter last name ""(.*)""")]
        public void WhenAUserEnterLastName(string txt)
        {
            signUpPage.EnterLastName(txt);
        }
        
        [When(@"a user phone number ""(.*)""")]
        public void WhenAUserPhoneNumber(string txt)
        {
            signUpPage.EnterPhoneNumber(txt);
        }
        
        [When(@"a user enter password ""(.*)""")]
        public void WhenAUserEnterPassword(string txt)
        {
            signUpPage.EnterPassWord(txt);
        }
        
        [When(@"a user confirm password ""(.*)""")]
        public void WhenAUserConfirmPassword(string txt)
        {
            signUpPage.EnterConfirmPassword(txt); 
        }
        
        [When(@"a user click on register")]
        public void WhenAUserClickOnRegister()
        {
            signUpPage.ClickRegister(); 
        }
        //[Then(@"email field is displayed")]
        //public void ThenEmailFieldIsDisplayed()
        //{
        //    //Assert.IsTrue(signUpPage.IsEmailFieldDisplayed());
        //}

        [Then(@"sign in is displayed")]
        public void ThenSignInIsDisplayed()
        {
            
            Assert.IsTrue(signUpPage.IsSignInPageDisplayed());
            //signUpPage.IsSignInPageDisplayed().Should().BeTrue();
        }





        [Then(@"error message is displayed")]
        public void ThenErrorMessageIsDisplayed()
        {
                    Assert.IsTrue(signUpPage.ErrorMessageDisplayed(), "Error Message: The Email Address field must contain a valid email address.");
        }

        [Then(@"Error is displayed")]
        public void ThenErrorIsDisplayed()
        {
            
        }

        [Then(@"The Email Address field is required is displayed\.")]
        public void ThenTheEmailAddressFieldIsRequiredIsDisplayed_()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(signUpPage.NoEmailMessageDisplayed(), "Error Message: The Email Address field is required");
        }


    }
}
