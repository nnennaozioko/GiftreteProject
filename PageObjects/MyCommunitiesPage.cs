using GiftreteCommunity.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GiftreteCommunity.PageObjects
{
    class MyCommunitiesPage
    {
        public IWebDriver driver;
       
        public MyCommunitiesPage()
        {
            driver = WebHooks.driver;
           
        }          
                  
                 
        IWebElement signIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement emailAddress => driver.FindElement(By.Id("user_email"));
        IWebElement password => driver.FindElement(By.Id("user_password"));
        IWebElement rememberMe => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/form/div[3]/div[1]/div/label"));
        IWebElement loginButton => driver.FindElement(By.CssSelector("#btn_signin"));
        IWebElement myCommunities => driver.FindElement(By.CssSelector("#navigation-widget-small > ul > li:nth-child(3) > a"));
        IWebElement createCommunity => driver.FindElement(By.CssSelector("body > div.content-grid > section > div.section-header > div.profile-header-info-actions > a > p"));
        IWebElement communityName => driver.FindElement(By.Id("name"));
        IWebElement communityHandle => driver.FindElement(By.Id("cleanname"));
        IWebElement locationddress => driver.FindElement(By.CssSelector("#autocomplete"));
        IWebElement category => driver.FindElement(By.CssSelector("#group_type_id"));
        IWebElement chooseFile => driver.FindElement(By.CssSelector("#files"));
        IWebElement membershipType => driver.FindElement(By.XPath("/html/body/div[2]/section/div[2]/div/div[2]/div/div/form/div[3]/div[2]/div[1]/div/label"));
        IWebElement communityWebsite => driver.FindElement(By.Id("website"));
        IWebElement community => driver.FindElement(By.CssSelector("#cke_1_contents"));
        IWebElement communityDescription => driver.FindElement(By.CssSelector("#cke_1_contents"));
        IWebElement createCommunityButton => driver.FindElement(By.CssSelector("#btn_create"));
        IWebElement homeIcon => driver.FindElement(By.CssSelector("body > div.content-grid > div.profile-header.v2 > div > div.profile-header-info-actions > a:nth-child(1) > svg"));
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
           
         public void SignIn()
        {
            signIn.Click();
        }        
        
        public void EmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }
        
        public void PassWord(string passwordtxt)
        {
            password.SendKeys(passwordtxt);
        } 
        
        public void RememberMeBox()
        {
            rememberMe.Click();
        }
    
        public void LoginButton()
        {
            loginButton.Click();
        }
        public void MyCommunities()
        {
            myCommunities.Click();
        }

        public void CreateCommunity()
        {
            createCommunity.Click();
        }
    
        public void CommunityName(string communityNametxt)
        {
            communityName.SendKeys(communityNametxt);
        }
    
        public void CommunityHandle(string communityHandletxt)
        {
            communityHandle.SendKeys(communityHandletxt);
        }
   
        public void LocationAddress(string Addresstxt)
        {
            locationddress.SendKeys(Addresstxt);
        }

        
        public void Category(string categorytext)
        {
            category.SendKeys(categorytext);
        }

        public void ChooseFile(string fileImage)
        {
           
            chooseFile.SendKeys(@"C:\Users\Nelly\source\repos\GiftreteCommunity\TestDataImages");
        }

        public void MembershipeType()
        {
            membershipType.Click();
        }

        public void CommunityWebsite(string websitetxt)
        {
            communityWebsite.SendKeys(websitetxt);
        }
        public void Community()
        {
            community.Click();
            
        }
        

        public void CommunityDescription(string descriptiontxt)
        {
            community.SendKeys(descriptiontxt);
        }

        public void CreateCommunityButton()
        {
            createCommunityButton.Click();
        }

        public bool HomeIconDisplayed()
        {
            return homeIcon.Displayed;
        }


    }
    
    
    
        






    
    

    
}