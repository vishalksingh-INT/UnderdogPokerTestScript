using NUnit.Framework;
using Altom.AltUnityDriver;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;
using System;
namespace Editor.TestUnderDogPoker.Tests

{
    public class SignupPageTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private SignupPage signupPage;
        private EmailSignupPage emailSignupPage;
        private LoginPage loginPage;
        private GoogleSignupPage googleSignupPage;
        public SignupPageTests()
        {
            LoggingScript.Instance.AddLog("Signup module Test Cases execution started");
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            emailSignupPage = new EmailSignupPage(altUnityDriver);
            loginPage = new LoginPage(altUnityDriver);
            googleSignupPage = new GoogleSignupPage(altUnityDriver);


        }
        [Test]
        public void Signup_TC_ID_1_2SignupPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_1 is started execution");
            Assert.True(signupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup page is loaded");
            LoggingScript.Instance.AddLog("Signup_TC_ID_1 is passed");
            //string pathToYourFile = @"F:\Screenshots\";
            //altUnityDriver.GetPNGScreenshot(pathToYourFile);

        }

        [Test]
        public void Signup_TC_ID_3_GoogleSignupScreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_3 is started execution");
            signupPage.ClickgoogleSignupButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Clicked on Google signup button");
            Assert.True(googleSignupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Google signup page is opned");
            LoggingScript.Instance.AddLog("Signup_TC_ID_3 is Passed");
        }

        [Test]
        public void Signup_TC_ID_9_10LoadEmailSignupScreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_9 is started execution");
            signupPage.ClickEmailSignupButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_9_10" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Clicked on Email signup button");
            Assert.True(emailSignupPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_9_10" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Email signup page is displayed");
            LoggingScript.Instance.AddLog("Signup_TC_ID_9 is passed");
        }

        [Test]
        public void Signup_TC_ID_13_TestLoginHereButtonLoadLoginScreen()
        {
            LoggingScript.Instance.AddLog("Login screen load test case is started execution");
            signupPage.PressLoginHereButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Clicked on Login here button");
            Assert.True(loginPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Login screen loaded, Test case is passed");
        }


        /* [Test]
         public void Test4WelcomeBonusReward()
         {
             signupPage.WelcomeBonusReward();

         }*/

        public void TestFindElement()
        {

            /*
                 altUnityDriver.LoadScene("Dashboard");
                 Thread.Sleep(2000);
                 altUnityDriver.FindObject(By.NAME, "Email_SignUp_Btn").Tap();
                 Thread.Sleep(4000);

                 altUnityDriver.FindObject(By.NAME, "Name").SetText("Vishal");

                 Thread.Sleep(1000);

                 altUnityDriver.FindObject(By.NAME, "Email").SetText("vishalk.singh@indusnet.co.in");
                 Thread.Sleep(1000);

                 altUnityDriver.FindObject(By.NAME, "Password").SetText("eGain@12345");
                 Thread.Sleep(1000);*/


        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}