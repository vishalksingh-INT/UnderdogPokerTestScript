using NUnit.Framework;
using Altom.AltUnityDriver;
using Editor.TestUnderDogPoker.Pages;
using System;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests
{
    public class WelcomeDailyRewardTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private WelcomeDailyRewardPage welcomeDailyRewardPage;
        private DashboardPage dashboardPage;
        SignupPage signupPage;
        SettingsPage settingsPage;
        LoginPage loginPage;
        //private StartPage startPage;
        public WelcomeDailyRewardTests()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);

            loginPage.LoginEmail();
            welcomeDailyRewardPage = new WelcomeDailyRewardPage(altUnityDriver);
            welcomeDailyRewardPage.Load();
            dashboardPage = new DashboardPage(altUnityDriver);
            //mainMenuPage = new MainMenuPage(altUnityDriver);


        }
        [Test]
        public void DailyReward_TC_1_TestDailyRewardPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("DailyReward_TC_1 Daily Reward page test started execution");
            Assert.True(welcomeDailyRewardPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "DailyReward_TC_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("DailyReward_TC_1 Daily Reward page test is passed");
        }

        [Test]
        public void DailyReward_TC_2_TestBackButtonLoadDashboard()
        {
            LoggingScript.Instance.AddLog("DailyReward_TC_2 Back button in dashboard page test started execution");
            welcomeDailyRewardPage.PressDailyBonusBackButton();
            Assert.True(dashboardPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "DailyReward_TC_2" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("DailyReward_TC_2 Back button in dashboard page test is passed");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }

}