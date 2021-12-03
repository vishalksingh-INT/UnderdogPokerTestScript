using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using System;
using Editor.TestUnderDogPoker.Pages;
using UnityEngine;

namespace Editor.TestUnderDogPoker.Tests

{
    public class LoginPageTests : IDisposable
    {


        private AltUnityDriver altUnityDriver;
        private SignupPage signupPage;
        private LoginPage loginPage;
        private ForgotPasswordPage forgotPasswordPage;
        private DashboardPage dashboardPage;
        public LoginPageTests()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);
            forgotPasswordPage = new ForgotPasswordPage(altUnityDriver);
            dashboardPage = new DashboardPage(altUnityDriver);
           
        }
        [Test]
        public void Login_TC_ID_1_Check_textboxes_Email_Password_buttons()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_1 test case execution started");
            loginPage.IsDisplayed();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("verifying the Login page is displayed or not");
            Assert.True(loginPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Login page is displayed");
            LoggingScript.Instance.AddLog("Login_TC_ID_1 PASSED");

        }
        [Test]
        public void Login_TC_ID_2_not_Filling_Data()
        {
            // LoggingScript.Instance.AddLog(loginPage.getAlertText());
            LoggingScript.Instance.AddLog("Login_TC_ID_2 test case execution started");
            loginPage.not_Filling_Data();
            LoggingScript.Instance.AddLog(loginPage.getAlertText());
            Debug.Log( loginPage.getAlertText());
            Debug.Log("Login_TC_ID_2_not_Filling_Data");
            Debug.Log(loginPage.getAlertText());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_2" + LoggingScript.Instance.Sreenshotend);
            //Debug.LogError(ErrorMessageScript.instance.errorMsgText);
            Assert.AreEqual(loginPage.getAlertText(), "Email cannot be empty.");
            LoggingScript.Instance.AddLog("ALERT message recived");
            LoggingScript.Instance.AddLog("Login_TC_ID_2 PASSED");

            //Debug.LogError(ErrorMessageScript.instance.errorMsgText);

        }
        [Test]
        public void Login_TC_ID_3_not_Filling_Email()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_3 test case execution started");
            loginPage.not_Filling_Email();
            Assert.AreEqual(loginPage.getAlertText(), "Email cannot be empty.");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("ALERT message recieved");
            LoggingScript.Instance.AddLog("Login_TC_ID_3 passed");

        }
        [Test]
        public void Login_TC_ID_4_Check_textboxes_Email_Password_buttons()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_4 test case execution started");
            loginPage.not_filling_password();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_4" + LoggingScript.Instance.Sreenshotend);
            Assert.AreEqual(loginPage.getAlertText(), "Password cannot be empty.");
            LoggingScript.Instance.AddLog("ALERT message recieved");
            LoggingScript.Instance.AddLog("Login_TC_ID_4 passed");

        }
        [Test]
        public void Login_TC_ID_5_9_passing_incorrect_Email_validPassword()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_5 test case execution started");
            loginPage.passing_incorrect_Email_validPassword();
            Assert.AreEqual(loginPage.getPopupText(), "Invalid login Credential.");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_5_9" + LoggingScript.Instance.Sreenshotend);
            loginPage.PressRetryButton();
            LoggingScript.Instance.AddLog("ALERT message recieved");
            LoggingScript.Instance.AddLog("Login_TC_ID_4 passed");

        }
        [Test]
        public void Login_TC_ID_10_LoginEmail()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_10 test case execution started");
            loginPage.LoginEmail();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_10" + LoggingScript.Instance.Sreenshotend);
            // Assert.AreEqual(loginPage.getAlertText(), "Hey Srinivas, Login Successful!");
            LoggingScript.Instance.AddLog("Login successfully");
            LoggingScript.Instance.AddLog("Login_TC_ID_10 passed");

        }
        [Test]
            public void Login_TC_ID_11_ForgotPasswordlink_present_Loginscreen()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_11 test case execution started");
            Assert.IsTrue(loginPage.ForgotPasswordlink_present_Loginscreen());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("verifying forget Password link is visible and enabled or not");
            LoggingScript.Instance.AddLog("Login_TC_ID_11 passed");
        }
        [Test]
        public void Login_TC_ID_12_CreateNow_Button()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_12 test case execution started");
            Assert.IsTrue(loginPage.CreateNow_Button());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_12" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("verifying create new link is visible and enabled or not");
            LoggingScript.Instance.AddLog("Login_TC_ID_11 passed");
        }


        [Test]
        public void TestAfterLoginLoadDashboardScreen()
        {
           // signupPage.PressLoginHereButton();
            
            Thread.Sleep(2000);
            loginPage.LoginEmail();
            Assert.True(dashboardPage.IsDisplayed());
        }
        
        [Test]
        public void TestForgotPwdbuttonLoadForgotPwdScreen()
        {
            loginPage.PressForgotPwdBtn();
            Assert.True(forgotPasswordPage.IsDisplayed());
        }
        [Test]
        public void Login_TC_ID_13_CreateButtonLoadSignupScreen()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_13 test case execution started");
            loginPage.PressCreateNowBtn();
            Assert.True(signupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup page is displayed");
            LoggingScript.Instance.AddLog("Login_TC_ID_13 passed");
        }

        [Test]
        public void ForgetPass_TC_ID_1_Load_ForgetpasswordScreen()
        {
            loginPage.PressForgotPwdBtn();
            Assert.True(forgotPasswordPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
        }
        [Test]
        public void TestEmailLogin()
        {
            loginPage.LoginEmail();

        }
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}