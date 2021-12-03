using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker
{
    public class UserFlow : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private SignupPage signupPage;
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private WelcomeDailyRewardPage welcomeDailyRewardPage;
        private HambergarMenuPage hambergarMenuPage;
        private SettingsPage settingsPage;
        private NotificationPage notificationPage;
        private ShopPage shopPage;

        public UserFlow()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            loginPage = new LoginPage(altUnityDriver);
            dashboardPage = new DashboardPage(altUnityDriver);
            welcomeDailyRewardPage = new WelcomeDailyRewardPage(altUnityDriver);
            hambergarMenuPage = new HambergarMenuPage(altUnityDriver);
            settingsPage = new SettingsPage(altUnityDriver);
            notificationPage = new NotificationPage(altUnityDriver);
            shopPage = new ShopPage(altUnityDriver);
        }
        public void Dispose()
        {
            altUnityDriver.Stop();

        }
        [Test]
        public void Test01SignupPageLoadedCorrectly()
        {
            Assert.True(signupPage.IsDisplayed());
        }
        [Test]
        public void Test02LoginHereButtonLoadLoginScreen()
        {
            Thread.Sleep(2000);
            signupPage.PressLoginHereButton();
            Thread.Sleep(2000);
            Assert.True(loginPage.IsDisplayed());
        }
        [Test]
        public void Test03AfterLoginLoadDailyBonusScreen()
        {
            
            loginPage.LoginEmail();
            Assert.True(welcomeDailyRewardPage.IsDisplayed());
        }
        [Test]
        public void Test04PressBackBuuttonLoadDashboardScreen()
        {
            welcomeDailyRewardPage.PressDailyBonusBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void Test05PressHamButtonLoadHamMenuScreen()
        {
            dashboardPage.PressHambergarMenu();
            Assert.True(hambergarMenuPage.IsDisplayed());
        }
        [Test]
        public void Test06PressSettButtonLoadSettingScreen()
        {
            hambergarMenuPage.PressSettingsButton();
            Assert.True(settingsPage.IsDisplayed());

        }
        [Test]
        public void Test07PressSettingsBackButtonLoadDashBoard()
        {
            settingsPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void Test08PressNotificationButtonLoadNotificationScreen()
        {
            dashboardPage.PressNotificationButton();
            Assert.True(notificationPage.IsDisplayed());


        }
        [Test]
        public void Test09PressNotBackButtonLoadDashBoard()
        {
            notificationPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void Test10PressREWButtonLoadREWARDScreen()
        {
            dashboardPage.PressRewardButton();
            Thread.Sleep(2000);
            Assert.True(welcomeDailyRewardPage.IsDisplayed());

        }
        [Test]
        public void Test11PressREWBackButtonLoadDashBoard()
        {
            welcomeDailyRewardPage.PressDailyBonusBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void Test12PressShopButtonLoadShopScreen()
        {
            dashboardPage.PressShopButton();
            Thread.Sleep(2000);
            Assert.True(shopPage.IsDisplayed());

        }
        [Test]
        public void Test13PressShopBackButtonLoadDashBoard()
        {
            shopPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void Test14PressLogoutButton()
        {
            dashboardPage.PressHambergarMenu();
            Thread.Sleep(2000);
            Assert.True(hambergarMenuPage.IsDisplayed());
            Thread.Sleep(2000);
            hambergarMenuPage.PressSettingsButton();
            Thread.Sleep(2000);
            Assert.True(settingsPage.IsDisplayed());
            Thread.Sleep(2000);
            settingsPage.PressLogoutButton();
            Thread.Sleep(2000);
            Assert.True(signupPage.IsDisplayed());



        }

    }
}