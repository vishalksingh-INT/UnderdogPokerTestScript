using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using System;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class EditProfileTest : IDisposable
    {
        AltUnityDriver altUnityDriver;

        SignupPage signupPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        PlayerProfilePage playerProfilePage;
        EditProfilePage editProfilePage;
        public EditProfileTest()
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
            dashboardPage.PressPlayerAvatarButton();
            playerProfilePage = new PlayerProfilePage(altUnityDriver);
            playerProfilePage.PressEditProfileButton();
        }

        [Test]
        public void TestEditProfileScreenDisplayedCorrectly()
        {
            Assert.True(editProfilePage.IsDisplayed());
        }
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
        [Test]
        public void TestUpdateProfile()
        {
            editProfilePage.UpdateNickname();
            editProfilePage.UpdateMobileNo();
            editProfilePage.PressSaveButton();
            editProfilePage.PressOkayButton();
        }


    }


}