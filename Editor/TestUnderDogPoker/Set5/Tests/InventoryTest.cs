using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class InventoryTest : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
       
        LoginPage loginPage;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        InventoryPage inventoryPage;
        public InventoryTest()
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
            hambergarMenuPage.PressInventoryButton();
            inventoryPage = new InventoryPage(altUnityDriver);

        }
        [Test]
        public void TestSettingsDisplayedCorrectly()
        {
            Assert.True(inventoryPage.IsDisplayed());
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}