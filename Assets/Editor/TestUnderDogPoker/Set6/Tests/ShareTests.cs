
using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class ShareTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        ShopPage shopPage;
        SharePage sharepage;

        public ShareTests()
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

        }
 

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }


    }

}