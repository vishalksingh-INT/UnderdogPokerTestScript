using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests
{
    public class WelcomeBonusRewardTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        WelcomeBonusRewardPage welcomeBonusRewardPage;
        SignupPage signupPage;
        EmailSignupPage emailSignupPage;
        NickNamePage nickNamePage;

        public WelcomeBonusRewardTests()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.ClickEmailSignupButton();
            emailSignupPage = new EmailSignupPage(altUnityDriver);
            emailSignupPage.EmailRegForm();

            welcomeBonusRewardPage = new WelcomeBonusRewardPage(altUnityDriver);
            nickNamePage = new NickNamePage(altUnityDriver);
           
           // emailSignupPage = new EmailSignupPage(altUnityDriver);


        }
        [Test]
        public void Signup_TC_ID_41_42_CliamButtonLoadNickName()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_41_42 Claim Bonus button test started execution");
            LoggingScript.Instance.AddLog("Email signup screen loaded succesfully");
            LoggingScript.Instance.AddLog("Giving inputs in email signup page");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_41_42" + LoggingScript.Instance.Sreenshotend);
            welcomeBonusRewardPage.PressClaimButton();

            LoggingScript.Instance.AddLog("Clicked on Claim button");
            Assert.True(nickNamePage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_41_42" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Signup_TC_ID_41_42_ Claim bonus test passed");
        }
       
        [Test]
        public void Signup_TC_ID_38_WelcomeBonusReward()
        {
            LoggingScript.Instance.AddLog("Welcome Bonus test started execution");
            Thread.Sleep(8000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_38" + LoggingScript.Instance.Sreenshotend);
            welcomeBonusRewardPage.PressClaimButton();
            LoggingScript.Instance.AddLog("Clicked on Claim button");
            Assert.True(nickNamePage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_38" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Welcome Bonus test passed");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
    }
}