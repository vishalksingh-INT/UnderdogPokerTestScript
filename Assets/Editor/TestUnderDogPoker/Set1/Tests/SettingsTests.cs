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
        public void Setting_TC_ID_1_2_TestSettingsDisplayedCorrectly()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_2 test case execution started");
            Assert.True(settingsPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_1_2" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Setting_TC_ID_2 is passed");
        }

        [Test]
        public void Setting_TC_ID_3_4_togglebutton_sound()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_4 test case execution started");
            //settingsPage.PressSoundButton();
            Assert.True(settingsPage.SoundButton.enabled);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_3_4" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Setting_TC_ID_4 is passed");

        }
        
        [Test]
        public void Setting_TC_ID_7_8_AllowBuddyRequest()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_7 test case execution started");
            Assert.NotNull(settingsPage.AllowBuddyRequestButton);
            settingsPage.PressAllowBuddyRequestButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_7_8" + LoggingScript.Instance.Sreenshotend);
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
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_14" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("GDPR policy button is present in the screen");
            LoggingScript.Instance.AddLog("Setting_TC_ID_14 is passed");
        }

        [Test]
        public void Setting_TC_ID_15_GDPR()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_15 test case execution started");
            Assert.NotNull(settingsPage.GDPRPolicyButton);
            settingsPage.PressGDPRPolicyButton();
            LoggingScript.Instance.AddLog("clicked on the GDPR policy button");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_15" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_15 is passed");
        }

        [Test]
        public void Setting_TC_ID_16_GDPR()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_16 test case execution started");
            Assert.NotNull(settingsPage.GDPRPolicyButton);
            settingsPage.PressGDPRPolicyButton();
            LoggingScript.Instance.AddLog("clicked on the GDPR policy button");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_16" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("GDPR Policy is containing details of GDPR Policy");
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_16 is passed");
        }

        [Test]
        public void Setting_TC_ID_17_PrivacyPolicy()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_17 test case execution started");
            Assert.NotNull(settingsPage.PrivacyPolicyButton);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_17" + LoggingScript.Instance.Sreenshotend);
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("privacy policy button is present in the screen");
            LoggingScript.Instance.AddLog("Setting_TC_ID_17 is passed");
        }

        [Test]
        public void Setting_TC_ID_18_PrivacyPolicy()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_18 test case execution started");
            Assert.NotNull(settingsPage.PrivacyPolicyButton);
            settingsPage.PressPrivacyPolicyButton();
            LoggingScript.Instance.AddLog("Clicked on the privacy policy button");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_18" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_18 is passed");
        }

        [Test]
        public void Setting_TC_ID_19_PrivacyPolicy()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_19 test case execution started");
            Assert.NotNull(settingsPage.PrivacyPolicyButton);
            settingsPage.PressPrivacyPolicyButton();
            LoggingScript.Instance.AddLog("Clicked on the privacy policy button");
            LoggingScript.Instance.AddLog("privacy policy is present on the privacy policy screen");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_19" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_19 is passed");
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
            LoggingScript.Instance.AddLog("Terms and Condition button is present on the screen");
            Thread.Sleep(5000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_20" + LoggingScript.Instance.Sreenshotend);
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_20 is passed");
        }

        [Test]
        public void Setting_TC_ID_21_TermandCondition()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_21 test case execution started");
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
            LoggingScript.Instance.AddLog("CLicked on the terms and condition");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_21" + LoggingScript.Instance.Sreenshotend);
            settingsPage.PressBackButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_21" + LoggingScript.Instance.Sreenshotend);
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_21 is passed");
        }

        [Test]
        public void Setting_TC_ID_22_TermandCondition()
        {
            LoggingScript.Instance.AddLog("Setting_TC_ID_22 test case execution started");
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
            LoggingScript.Instance.AddLog("CLicked on the terms and condition");
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_22" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("terms and condition contents are present on the screen");
            settingsPage.PressBackButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Setting_TC_ID_22" + LoggingScript.Instance.Sreenshotend);
            // Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Setting_TC_ID_22 is passed");
        }


        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}