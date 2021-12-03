using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class NotificationTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        NotificationPage notificationPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        SignupPage signupPage;
    
    public NotificationTests()
    {

        altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
        loginPage = new LoginPage(altUnityDriver);
            loginPage.LoginEmail();
        dashboardPage = new DashboardPage(altUnityDriver);
         dashboardPage.PressNotificationButton();
            notificationPage = new NotificationPage(altUnityDriver);

    }


    [Test]
    public void Notification_TC_ID_3_NotificationsDisplayed()
    {
            LoggingScript.Instance.AddLog("Notification_TC_ID_3 Notification screen display Test is started execution");
            Assert.True(notificationPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            notificationPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
            altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
            LoggingScript.Instance.AddLog("Notification_TC_ID_3 is Passed");
    }

    [Test]
    public void Notification_TC_ID_3()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_3 Notification Page verification test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        Assert.True(notificationPage.IsAllTabDisplayed());
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_3" + LoggingScript.Instance.Sreenshotend);
        LoggingScript.Instance.AddLog("Notification_TC_ID_3 is Passed");
    }
    
    [Test]
    public void Notification_TC_ID_10()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_10 News Tab verification test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        Assert.True(notificationPage.IsAllTabDisplayed());
        notificationPage.NewsTabClick();
        notificationPage.IsNewsTabDisplayed();
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_10" + LoggingScript.Instance.Sreenshotend);
        LoggingScript.Instance.AddLog("Notification_TC_ID_10 is Passed");
    }

    [Test]
    public void Notification_TC_ID_12()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_12 Support Tab verification test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        Assert.True(notificationPage.IsAllTabDisplayed());
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_12" + LoggingScript.Instance.Sreenshotend);
        notificationPage.SupportTabClick();
        LoggingScript.Instance.AddLog("Support Tab is opened");
        LoggingScript.Instance.AddLog("Notification_TC_ID_12 is Passed");
    }

    [Test]
    public void Notification_TC_ID_13()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_13 Support Tab Content verification test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        Assert.True(notificationPage.IsAllTabDisplayed());
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
        notificationPage.SupportTabClick();
        LoggingScript.Instance.AddLog("Support Tab is opened");
        notificationPage.IsSupportTabDisplayed();
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_13" + LoggingScript.Instance.Sreenshotend);
        LoggingScript.Instance.AddLog("Notification_TC_ID_13 is Passed");
    }

    [Test]
    public void Notification_TC_ID_15()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_15 Message Tab test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_15" + LoggingScript.Instance.Sreenshotend);
        LoggingScript.Instance.AddLog("By default message tab is opened");
        LoggingScript.Instance.AddLog("Notification_TC_ID_15 is Passed");
    }

    [Test]
    public void Notification_TC_ID_16()
    {
        LoggingScript.Instance.AddLog("Notification_TC_ID_16 Support Tab verification test is started execution");
        Assert.True(notificationPage.IsDisplayed());
        Assert.True(notificationPage.IsAllTabDisplayed());
        notificationPage.SupportTabClick();
        LoggingScript.Instance.AddLog("Support Tab is opened");
        Thread.Sleep(30000);
        altUnityDriver.GetPNGScreenshot(LoggingScript.Instance.pathToYourFile + "Notification_TC_ID_16" + LoggingScript.Instance.Sreenshotend);
        notificationPage.MessageTabClick();
        LoggingScript.Instance.AddLog("Inside Message Tab sceen");
        LoggingScript.Instance.AddLog("Notification_TC_ID_16 is Passed");
    }


        public void Dispose()
    {
        altUnityDriver.Stop();
        Thread.Sleep(1000);
    }


}

}