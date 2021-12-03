using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using System;
using Editor.TestUnderDogPoker.Pages;
using UnityEngine;

namespace Editor.TestUnderDogPoker.Tests
{
    public class EmailSignupTests : IDisposable
    {
   private AltUnityDriver altUnityDriver;
     private   EmailSignupPage emailSignupPage;
      private  SignupPage signupPage;
        private NickNamePage nickNamePage;
        private LoginPage loginPage;
        private WelcomeBonusRewardPage welcomeBonusRewardPage;
    public void Dispose()
    {
        altUnityDriver.Stop();
        Thread.Sleep(1000);
    }
    public EmailSignupTests()
    {
            LoggingScript.Instance.AddLog("Email signup Test Cases exection started");
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.ClickEmailSignupButton();
            emailSignupPage = new EmailSignupPage(altUnityDriver);
            nickNamePage = new NickNamePage(altUnityDriver);
            loginPage = new LoginPage(altUnityDriver);
            welcomeBonusRewardPage = new WelcomeBonusRewardPage(altUnityDriver);
        
           
        }


    [Test]
    public void TestEmailSignupPageLoadedCorrectly()
    {
        Assert.True(emailSignupPage.IsDisplayed());
    }

        [Test]
        public void EmailSignup_TC_1_TestEmailRegFormSubmit()
        {
           /* signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());*/
            Thread.Sleep(2000);
            emailSignupPage.EmailRegForm();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "EmailSignup_TC_1" + LoggingScript.Instance.Sreenshotend);
            Assert.True(nickNamePage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "EmailSignup_TC_1" + LoggingScript.Instance.Sreenshotend);
            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Congratulation you have been successfully registered");
        }

        [Test]
        public void EmailSignup_TC_ID_11_Name_cannot_be_empty_AlertMessage()
        {
            LoggingScript.Instance.AddLog("EmailSignup_TC_ID_11_Name_cannot_be_empty_AlertMessage started execution");
            //signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "EmailSignup_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            Thread.Sleep(30000);
            emailSignupPage.EmailRegFormNamealertMessage();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "EmailSignup_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            Thread.Sleep(30000);
            Console.WriteLine(emailSignupPage.GetErorrMessageText());
            Thread.Sleep(30000);
            LoggingScript.Instance.AddLog(emailSignupPage.GetErorrMessageText());
            //string text= emailSignupPage.GetErorrMessageText(),
            Assert.AreEqual("Name cannot be empty.", emailSignupPage.GetErorrMessageText());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "EmailSignup_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("EmailSignup_TC_ID_11_Name_cannot_be_empty_AlertMessage Ended execution");



        }
        public void Signup_TC_ID_12Email_cannot_be_emptyMessage()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_12_Email_cannot_be_emptyMessage started execution");
            signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            Thread.Sleep(2000);
            emailSignupPage.EmailRegFormEmailalertMessage();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Email cannot be empty");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_12" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_12_Email_cannot_be_emptyMessage ended execution");

        }
        [Test]
        public void Signup_TC_ID_13Password_cannot_be_emptyMessage()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_13Password_cannot_be_emptyMessage started execution");
            //signupPage.ClickEmailSignupButton();
            // Assert.True(emailSignupPage.IsDisplayed());

            emailSignupPage.EmailRegFormPasswordalertMessage();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password cannot be empty.");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_13Password_cannot_be_emptyMessage ended execution");
        }

        [Test]
        public void Signup_TC_ID_14OkayButton()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_14OkayButton started execution");
            /*signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            Thread.Sleep(2000);*/
            emailSignupPage.EmailRegFormPasswordalertMessage();

            Assert.AreEqual(emailSignupPage.GetOkayButtonText(), "OKAY");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_14" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_14OkayButton ended execution");
        }
        //Signup_TC_ID_15
        [Test]
        public void Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen started execution");

            emailSignupPage.EmailRegFormPasswordalertMessage();

            // Assert.AreEqual(emailSignupPage.GetOkayButtonText(), "OkayButton");

            emailSignupPage.PressOkayButton();
            Assert.True(emailSignupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_15_19" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen ended execution");
        }
        //existing Username
        public void Signup_TC_ID_16_existingUsernamee()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_16_existingUsername started execution");

            emailSignupPage.existingUsername();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_16" + LoggingScript.Instance.Sreenshotend);
            Assert.AreEqual(emailSignupPage.GetwrongnameMessageText(), "This username is already exists");
            //emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_16_existingUsername ended execution");
        }
        //
        [Test]
        public void Signup_TC_ID_20_existingemailid()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_20_existingemailid started execution");
            emailSignupPage.ExistingEmailid();

            Assert.AreEqual(emailSignupPage.GetWrongEmail_Text(), "This E-mail already exists.");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_20" + LoggingScript.Instance.Sreenshotend);
            //emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_20_existingemailid ended execution");
        }

        [Test]
        public void Signup_TC_ID_23_password_limit_Min()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_Min started execution");

            emailSignupPage.PasswordLimitMin();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password must contain a minimum of 1 upper, lower and numeric character");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_23" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_Min ended execution");
        }
        [Test]
        public void Signup_TC_ID_24_password_limit_Max()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_Max started execution");

            emailSignupPage.PasswordLimitMax();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), " should not accept the more then 32 alphanumeric");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signupp_TC_ID_24" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_MAX ended execution");
        }

        [Test]
        public void Signup_TC_ID_25_Passwordonlynumbers()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_25_Passwordonlynumbers started execution");

            emailSignupPage.Passwordonlynumbers();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password must contain a minimum of 1 upper, lower and numeric character");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_25" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_25_Passwordonlynumbers ended execution");
        }

        [Test]
        public void Signup_TC_ID_26_incorrectReferralcode()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_26_incorrectReferralcode started execution");

            emailSignupPage.incorrectReferralcode();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Congratulation you have been successfully registered");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_26" + LoggingScript.Instance.Sreenshotend);
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_26_incorrectReferralcode ended execution");
        }

        [Test]
        public void Signup_TC_ID_30_withoutAgreeterms()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_30_withoutAgreeterms started execution");
            emailSignupPage.withoutAgreeterms();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Please accept our terms and condition");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_30" + LoggingScript.Instance.Sreenshotend);
            //Please agree to T&C.
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_30_withoutAgreeterms ended execution");

        }


        [Test]
        public void Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen started execution");
            emailSignupPage.PressLoginHereButton();
            //signupPage.PressLoginHereButton();
            Assert.True(loginPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_32" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen ended execution");

        }

        [Test]
        public void Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen started execution");
            emailSignupPage.EmailRegForm();
            emailSignupPage.PressOkayButton();

            Assert.True(welcomeBonusRewardPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_33_34_35" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen ended execution");
        }

    }

}