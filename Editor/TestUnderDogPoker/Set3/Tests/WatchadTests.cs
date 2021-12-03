using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class WatchadTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;

        LoginPage loginPage;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        WatchadPage watchadPage;
        public WatchadTests()
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
            hambergarMenuPage.PressWatchADButton();
            watchadPage = new WatchadPage(altUnityDriver);

        }
        [Test]
        public void TestSettingsDisplayedCorrectly()
        {
            Assert.True(watchadPage.IsDisplayed());
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}