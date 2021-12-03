using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class NickNameTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private NickNamePage nickNamePage;
        //private EmailSignupPage emailSignupPage;
        private WelcomeDailyRewardPage welcomeDailyRewardPage;
        public NickNameTests()
        {
            altUnityDriver = new AltUnityDriver();
            nickNamePage = new NickNamePage(altUnityDriver);
            nickNamePage.Load();
            // emailSignupPage = new EmailSignupPage(altUnityDriver);
            welcomeDailyRewardPage = new WelcomeDailyRewardPage(altUnityDriver);


        }
        [Test]
        public void Login_TC_ID_23_NamePageLoadedCorrectly()
        {
            Assert.True(nickNamePage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_23" + LoggingScript.Instance.Sreenshotend);
        }
       

      [Test]
        public void Login_TC_ID_42_TestNickName()
        {
            nickNamePage.SetNickName();
            Thread.Sleep(1000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Login_TC_ID_42" + LoggingScript.Instance.Sreenshotend);
            nickNamePage.PressOkayButtonNickName();
          //  Assert.True(emailSignupPage.IsDisplayed());

        }
        [Test]
        public void Signup_TC_ID_43_Setonlyspace_NickName()
        {
            nickNamePage.Setonlyspace_NickName();
            Thread.Sleep(1000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_43" + LoggingScript.Instance.Sreenshotend);
            nickNamePage.PressOkayButtonNickName();
            //  Assert.True(emailSignupPage.IsDisplayed());

        }
        [Test]
        public void Signup_TC_ID_44_Setalreadypresent_NickName()
        {
            nickNamePage.Setalreadypresent_NickName();
            Thread.Sleep(1000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_44" + LoggingScript.Instance.Sreenshotend);
            nickNamePage.PressOkayButtonNickName();
            //  Assert.True(emailSignupPage.IsDisplayed());

        }
        [Test]
        public void Signup_TC_ID_45_46_Set_alphanumericdata_NickName()
        {
            nickNamePage.Set_alphanumericdata_NickName();
            Thread.Sleep(1000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Signup_TC_ID_45_46" + LoggingScript.Instance.Sreenshotend);
            nickNamePage.PressOkayButtonNickName();
            Assert.True(welcomeDailyRewardPage.IsDisplayed());

        }

       
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }


    }
}