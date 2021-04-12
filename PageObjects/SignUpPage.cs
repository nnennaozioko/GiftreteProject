using GiftreteCommunity.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace GiftreteCommunity.PageObjects
{
    class SignUpPage
    {
        //public IWebDriver driver = WebHooks.driver;
        public IWebDriver driver;

        public SignUpPage()
        {
            driver = WebHooks.driver;
        }

        IWebElement signUp => driver.FindElement(By.CssSelector("nav > div > div.pa0.flex.justify-end.dn.df-ns.ml7-m > a:nth-child(2)"));
        IWebElement email => driver.FindElement(By.Id("email"));
        IWebElement firstName => driver.FindElement(By.CssSelector("#first_name"));
        IWebElement lastName => driver.FindElement(By.CssSelector("#last_name"));
        IWebElement phoneNumber => driver.FindElement(By.Id("mobile"));
        IWebElement passWord => driver.FindElement(By.CssSelector("#password"));
        IWebElement confirmPassword => driver.FindElement(By.CssSelector("#confirm_password"));
        IWebElement register => driver.FindElement(By.Id("btn_register"));
        IWebElement emailField => driver.FindElement(By.Id("user_email"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("#dng_id"));
        IWebElement signIn => driver.FindElement(By.CssSelector("div.landing-form > div:nth-child(1) > h2"));
        IWebElement error_Message => driver.FindElement(By.CssSelector(""));
        IWebElement noEmailMessage => driver.FindElement(By.CssSelector("#dng_msg > p"));




        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickSignUp()
        {
            signUp.Click();
        }

        public void EnterEmail(string emailtxt)
        {
            email.SendKeys(emailtxt);
       }

        public void EnterFirstName(string firstNametxt)
        {
            firstName.SendKeys(firstNametxt);
        }

        public void EnterLastName(string lastNametxt)
        {
            lastName.SendKeys(lastNametxt);
        }

       public void EnterPhoneNumber(string phoneNumbertxt)
        {
            phoneNumber.SendKeys(phoneNumbertxt);
        }

        public void EnterPassWord(string passWordtxt)
        {
            passWord.SendKeys(passWordtxt);
        }

        public void EnterConfirmPassword(string confirmPasswordtxt)
        {
            confirmPassword.SendKeys(confirmPasswordtxt);
        }

        public void ClickRegister()
        {
            register.Click();

        }

        //public bool IsEmailFieldDisplayed()
        //{
        //    return emailField.Displayed;

        //    //return driver.Url.Contains("");
        //}

        public bool ErrorMessageDisplayed()
        {
            return errorMessage.Displayed;
        }

        public bool IsSignInPageDisplayed()
        {
            return signIn.Displayed;
        }

        public bool NoEmailMessageDisplayed()
        {
            return noEmailMessage.Displayed;
        }
    }
    

}
