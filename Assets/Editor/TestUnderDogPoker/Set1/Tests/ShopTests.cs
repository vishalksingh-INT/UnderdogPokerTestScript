
using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class ShopTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        ShopPage shopPage;
        HambergarMenuPage hambergarMenuPage;

        public ShopTests()
        {

            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            Thread.Sleep(2000);
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);
            loginPage.LoginEmail();
            dashboardPage = new DashboardPage(altUnityDriver);
            Thread.Sleep(2000);
            dashboardPage.PressShopButton();
            shopPage = new ShopPage(altUnityDriver);

        }
        [Test]
        public void Shop_TC_ID_1_ShopPage()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_1 Shop screen test display case execution started");
            Assert.True(shopPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_1" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Shop_TC_ID_1 test passed");
        }

        [Test]
        public void Shop_TC_ID_10_gemsTab()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_10 Shop screen gems tab test case execution started");
            shopPage.GemsButtonButton();
            Assert.True(shopPage.IsGemsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_10" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Shop_TC_ID_10 test passed");
        }

        [Test]
        public void Shop_TC_ID_24_giftTab()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_24 Shop screen gift tab test case execution started");
            shopPage.GiftButtonButton();
            Assert.True(shopPage.IsGiftDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_24" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Shop_TC_ID_24 test passed");
        }

        [Test]
        public void Shop_TC_ID_26_GiftPackage()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_26 Gift Package test case execution started");
            shopPage.GiftButtonButton();
            Assert.True(shopPage.IsGiftDisplayed());
            shopPage.GiftPackageButton();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_26" + LoggingScript.Instance.Sreenshotend);
            shopPage.PurchaseGiftscreen();
            LoggingScript.Instance.AddLog("Shop_TC_ID_26 test passed");
        }

        [Test]
        public void Shop_TC_ID_21_InsultPackage()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_21 Insult Purchasing test case execution started");
            shopPage.InsultButton();
            shopPage.PurchaseInsult();
            Thread.Sleep(100000);
            shopPage.PurchaseGiftscreen();
            Thread.Sleep(50000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_21" + LoggingScript.Instance.Sreenshotend);
            shopPage.BckButton();
            dashboardPage.PressHambergarMenu();
            hambergarMenuPage.PressInventoryButton();
            Thread.Sleep(30000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_21" + LoggingScript.Instance.Sreenshotend);
            shopPage.InsultNotification();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_21" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Insult has been added succesfully");
            LoggingScript.Instance.AddLog("Shop_TC_ID_21 test passed");
        }


        [Test]
        public void Shop_TC_ID_28_GiftPackage()
        {
            LoggingScript.Instance.AddLog("Shop_TC_ID_28 Gift Purchasing test case execution started");
            shopPage.GiftButtonButton();
            Assert.True(shopPage.IsGiftDisplayed());
            shopPage.PurchaseOneGift();
            Thread.Sleep(100000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_28" + LoggingScript.Instance.Sreenshotend);
            shopPage.PurchaseGiftscreen();
            Thread.Sleep(50000);
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_28" + LoggingScript.Instance.Sreenshotend);
            shopPage.BckButton();
            dashboardPage.PressHambergarMenu();
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Shop_TC_ID_28" + LoggingScript.Instance.Sreenshotend);
            hambergarMenuPage.PressInventoryButton();
            Thread.Sleep(30000);
            Assert.AreEqual(shopPage.getGiftText(), "Pizza Slice");
            LoggingScript.Instance.AddLog("gift has been added succesfully");
            LoggingScript.Instance.AddLog("Shop_TC_ID_28 test passed");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }


    }

    }