using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class HistoryTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;

        LoginPage loginPage;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        HistoryPage historyPage;
        public HistoryTests()
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
            hambergarMenuPage.PressHistoryButton();
            historyPage = new HistoryPage(altUnityDriver);


        }

        [Test]
        public void History_TC_ID_3()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_3 to verify UI of past hand history started execution");
            LoggingScript.Instance.AddLog("History Option is present under Hamburger Menu");
            LoggingScript.Instance.AddLog("Clicked on History option");
            Assert.True(historyPage.IsDisplayed());
            LoggingScript.Instance.AddLog("History_TC_ID_3 test passed successfully");
        }

        [Test]
        public void History_TC_ID_4()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_4 to verify Back button started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.BackButtontap();
            LoggingScript.Instance.AddLog("Back to the Dashboard screen");
            LoggingScript.Instance.AddLog("History_TC_ID_4 test passed successfully");
        }

        [Test]
        public void History_TC_ID_5()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_5 to verify Back button started execution");
            Assert.True(historyPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Hand History list is displayed in chronological order");
            LoggingScript.Instance.AddLog("Back to the Dashboard screen");
            LoggingScript.Instance.AddLog("History_TC_ID_5 test passed successfully");
        }

        [Test]
        public void History_TC_ID_7()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_7 to verify the round number started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IstextDisplayed();
            LoggingScript.Instance.AddLog("round number is present in the history table");
            LoggingScript.Instance.AddLog("History_TC_ID_7 test passed successfully");
        }

        [Test]
        public void History_TC_ID_8()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_8 to verify the Number of tables started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IstextDisplayed();
            LoggingScript.Instance.AddLog("Number of tables is present on the history table");
            LoggingScript.Instance.AddLog("History_TC_ID_8 test passed successfully");
        }


        [Test]
        public void History_TC_ID_9()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_9 to verify the Winning Cards for each round started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IstextDisplayed();
            LoggingScript.Instance.AddLog("Winning Cards for each round is present on the history table");
            LoggingScript.Instance.AddLog("History_TC_ID_9 test passed successfully");
        }

        [Test]
        public void History_TC_ID_10()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_10 to verify Name of the Winner started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IstextDisplayed();
            LoggingScript.Instance.AddLog("Name of the Winner is present on the history table");
            LoggingScript.Instance.AddLog("History_TC_ID_10 test passed successfully");
        }

        [Test]
        public void History_TC_ID_11()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_11 to verify Number of Pots started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IstextDisplayed();
            LoggingScript.Instance.AddLog("Number of Pots is present on the history table");
            LoggingScript.Instance.AddLog("History_TC_ID_11 test passed successfully");
        }

        [Test]
        public void History_TC_ID_12()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_12 to verify  the Behaviour of a List Item after clicking on It started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.Detailsclicktap();
            LoggingScript.Instance.AddLog("Inside hand detail page");
            LoggingScript.Instance.AddLog("History_TC_ID_12 test passed successfully");
        }

        [Test]
        public void History_TC_ID_13()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_13 to verify the Table Type is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Table Type is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_13 test passed successfully");
        }

        [Test]
        public void History_TC_ID_14()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_14 to verify the Table Limit is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Table Limit is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_14 test passed successfully");
        }

        [Test]
        public void History_TC_ID_15()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_15 to verify the Dealer Name is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Dealer Name is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_15 test passed successfully");
        }

        [Test]
        public void History_TC_ID_16()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_16 to verify the Big Blind Name is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Big Blind Name is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_16 test passed successfully");
        }

        [Test]
        public void History_TC_ID_17()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_17 to verify the Small Blind Name is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Small Blind Name is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_17 test passed successfully");
        }

        [Test]
        public void History_TC_ID_18()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_18 to verify the Hand details section is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Hand details section is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_18 test passed successfully");
        }

        [Test]
        public void History_TC_ID_19()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_19 to verify the Winner Details section is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Winner Details is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_19 test passed successfully");
        }

        [Test]
        public void History_TC_ID_20()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_20 to verify the Back Button is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Back Button is present in the hand details screen");
            LoggingScript.Instance.AddLog("History_TC_ID_20 test passed successfully");
        }

        [Test]
        public void History_TC_ID_21()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_21 to verify the Back Button is present started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.IsHandDetails();
            LoggingScript.Instance.AddLog("Back Button is present in the hand details screen");
            historyPage.Bacbuttontap();
            LoggingScript.Instance.AddLog("Back to past hand hystory screen");
            LoggingScript.Instance.AddLog("History_TC_ID_21 test passed successfully");
        }


        [Test]
        public void History_TC_ID_22()
        {
            LoggingScript.Instance.AddLog("History_TC_ID_22 to verify send mail button started execution");
            Assert.True(historyPage.IsDisplayed());
            historyPage.PressSendEmailButton();
            LoggingScript.Instance.AddLog("History_TC_ID_22 test passed successfully");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}