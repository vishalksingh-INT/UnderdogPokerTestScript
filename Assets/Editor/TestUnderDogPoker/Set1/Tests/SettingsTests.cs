using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class SettingsTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
        SettingsPage settingsPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        public SettingsTests()
        {

            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);
           
            loginPage.LoginEmail();
            dashboardPage = new DashboardPage(altUnityDriver);
            dashboardPage.PressHambergarMenu();
            hambergarMenuPage = new HambergarMenuPage(altUnityDriver);
           
            hambergarMenuPage.PressSettingsButton();
            settingsPage = new SettingsPage(altUnityDriver);

        }
        [Test]
        public void Setting_TC_ID_2_TestSettingsDisplayedCorrectly()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_2 test case execution started");
            Assert.True(settingsPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_2" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Setting_TC_ID_2 is passed");
        }

        [Test]
        public void Setting_TC_ID_4_togglebutton_sound()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_4 test case execution started");
            //settingsPage.PressSoundButton();
            Assert.True(settingsPage.SoundButton.enabled);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_4" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Setting_TC_ID_4 is passed");

        }
        
        [Test]
        public void Setting_TC_ID_7_AllowBuddyRequest()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_7 test case execution started");
            Assert.NotNull(settingsPage.AllowBuddyRequestButton);
            settingsPage.PressAllowBuddyRequestButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_7" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            //Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_7 is passed");
        }
        [Test]
        public void Setting_TC_ID_11_CCPA()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_11 test case execution started");
            Assert.NotNull(settingsPage.CCPAPolicyButton);
            settingsPage.PressCCPAPolicyButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_11" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_11 is passed");
        }

        [Test]
        public void Setting_TC_ID_14_GDPR()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_14 test case execution started");
            Assert.NotNull(settingsPage.GDPRPolicyButton);
            settingsPage.PressGDPRPolicyButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_14" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_14 is passed");
        }

        [Test]
        public void Setting_TC_ID_17_PrivacyPolicy()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_17 test case execution started");
            Assert.NotNull(settingsPage.PrivacyPolicyButton);
            settingsPage.PressPrivacyPolicyButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_17" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_17 is passed");
        }
        
        [Test]
        public void Setting_TC_ID_20_TermandCondition()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_20 test case execution started");
            Thread.Sleep(20000);
            settingsPage.PressBackButton();
            Thread.Sleep(2000);
            settingsPage.PressBackButton();
            Thread.Sleep(2000);
            dashboardPage.PressHambergarMenu();
            hambergarMenuPage.PressSettingsButton();
            //Assert.NotNull(settingsPage.TCButton);
            Thread.Sleep(5000);
            settingsPage.PressTCButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_20" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_20" + LoggingScript.Instance.Sreenshotend);
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_20 is passed");
        }
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}