using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class DashboardTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        LoginPage loginPage;
        SignupPage signupPage;
        //private EmailSignupPage emailSignupPage;
        public DashboardTests()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);

            loginPage.LoginEmail();
            dashboardPage = new DashboardPage(altUnityDriver);
            dashboardPage.Load();
            hambergarMenuPage = new HambergarMenuPage(altUnityDriver);

        }
        [Test]
        public void Dashboard_TC_ID_1_DashboardPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_1 is started execution");
            Assert.True(dashboardPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Dashboard_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Dashboard Page is displayed");
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_1 is passed");
        }


        [Test]
        public void Dashboard_TC_ID_6_Hembergermenu()
        {
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_6 is started execution");
            dashboardPage.PressHambergarMenu();
            Assert.True(hambergarMenuPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Dashboard_TC_ID_6" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_6 is passed");
        }
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }

    }