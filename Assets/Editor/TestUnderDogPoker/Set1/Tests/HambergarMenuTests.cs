using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class HambergarMenuTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
        HambergarMenuPage hambergarMenuPage;
        
        LoginPage loginPage;
        DashboardPage dashboardPage;
        public HambergarMenuTests()
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


        }
        [Test]
        public void HamburgerMenu_TC_1_TestHamburderDisplayedCorrectly()
        {
            Assert.True(hambergarMenuPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + " HamburgerMenu_TC_1" + LoggingScript.Instance.Sreenshotend);
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}