using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class ForgotPasswordTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
        ForgotPasswordPage forgotPasswordPage;
        LoginPage loginPage;
       

        public ForgotPasswordTests()
        {

            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);
            loginPage.PressForgotPwdBtn();
            forgotPasswordPage = new ForgotPasswordPage(altUnityDriver);


        }
        [Test]
        public void ForgetPass_TC_ID_2ForgotPasswordDisplayedCorrectly()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_2 is started execution");
            Assert.True(forgotPasswordPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_2" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Forget Password page is displayed");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_2 is Passed");
        }

        [Test]
        public void ForgetPass_TC_ID_3_backbutton_redirected_LoginscreenCorrectly()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_3 is started execution");
            forgotPasswordPage.PressBackButton();
            LoggingScript.Instance.AddLog("Clicked on Back button in forget password page");
            Assert.True(loginPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Redirected by to the login page");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_3 is Passed");
        }
        //
        [Test]
        public void ForgetPass_TC_ID_4_LoginEmail()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_4 is started execution");
            forgotPasswordPage.notfillingdata();
            Assert.True(forgotPasswordPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_4" + LoggingScript.Instance.Sreenshotend);
            //Assert.AreEqual(forgotPasswordPage.getAlertText(), "Email cannot be empty.");
            LoggingScript.Instance.AddLog("Alert Message recieved");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_4 is Passed");
        }
        //ForgetPass_TC_ID_5
        //
        [Test]
        public void ForgetPass_TC_ID_5_passingInvalidEmailID()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_5 is started execution");
            forgotPasswordPage.passingInvalidEmailID();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_5" + LoggingScript.Instance.Sreenshotend);
            forgotPasswordPage.PressOkayButton();
            Thread.Sleep(2000);
            LoggingScript.Instance.AddLog("ALERT messages recieved as Please enter a valid email address.");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_5 is Passed");
        }
        [Test]
        public void ForgetPass_TC_ID_6_entersnotregisteredemailid()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_6 is started execution");
            forgotPasswordPage.entersnotregisteredemailid();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_6" + LoggingScript.Instance.Sreenshotend);
            forgotPasswordPage.PressOkayButton();
            // Console.WriteLine("alertmessage", forgotPasswordPage.getAlertText());
            //Assert.AreEqual(forgotPasswordPage.getAlertText(), "Email id does not exists");
            LoggingScript.Instance.AddLog("ALERT messages recieved as Email id does not exists");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_6 is Passed");
        }

        [Test]
        public void ForgetPass_TC_ID_8_validOTP_redirected_resetpasswordscreen()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_8 is started execution");
            forgotPasswordPage.SetEmailID();
            forgotPasswordPage.PressOkayButton();
            Assert.True(forgotPasswordPage.CreaatePasswordIsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_8" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_8 is Passed");
        }

        [Test]
        public void ForgetPass_TC_ID_11_passwordpassing_numbers()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_11 is started execution");
            forgotPasswordPage.SetEmailID();
            forgotPasswordPage.PressOkayButton();
            forgotPasswordPage.SetOTP();
            forgotPasswordPage.PressSubmitButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            forgotPasswordPage.passwordpassing_numbers();
            Assert.AreEqual(forgotPasswordPage.getAlertText(), "Password must contain a minimum of 1 upper, lower and numeric character");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_11 is Passed");



        }

        [Test]
        public void ForgetPass_TC_ID_12_errormessage_password_confirmpassword_notmatches()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_12 is started execution");
            forgotPasswordPage.SetEmailID();
            forgotPasswordPage.PressOkayButton();
            forgotPasswordPage.SetOTP();
            forgotPasswordPage.PressSubmitButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_12" + LoggingScript.Instance.Sreenshotend);
            forgotPasswordPage.errormessage_password_confirmpassword_notmatches();
            Assert.AreEqual(forgotPasswordPage.getAlertText(), "New and Confirm new Password must be same.");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_12" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_12 is Passed");


        }


        [Test]
        public void ForgetPass_TC_ID_13_ForgotPassword()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_13 is started execution");
            forgotPasswordPage.SetEmailID();
            
            forgotPasswordPage.PressOkayButton();
            
            forgotPasswordPage.SetOTP();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            forgotPasswordPage.PressSubmitButton();
            
            forgotPasswordPage.CreaatePassword();

            Assert.AreEqual(forgotPasswordPage.getAlertText(), "Password updated successfully");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_13 is Passed");
        }

        [Test]
        public void ForgetPass_TC_ID_14_LoginEmail()
        {
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_14 is started execution");
            forgotPasswordPage.PressBackButton();
            Thread.Sleep(80000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "ForgetPass_TC_ID_14" + LoggingScript.Instance.Sreenshotend);
            loginPage.LoginEmail();
            //Assert.AreEqual(loginPage.getAlertText(), "Hey sam, Login Successful!");
            LoggingScript.Instance.AddLog("ForgetPass_TC_ID_14 is Passed");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}