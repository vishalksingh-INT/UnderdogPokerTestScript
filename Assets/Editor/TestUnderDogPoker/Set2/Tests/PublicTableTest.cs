using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using System;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class PublicTableTest : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private DashboardPage dashboardPage;

        SignupPage signupPage;
        LoginPage loginPage;
        PublicTablePage publicTablePage;
        
       
        public PublicTableTest()
        {
            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            Thread.Sleep(2000);
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);
            loginPage.LoginEmail();
            dashboardPage = new DashboardPage(altUnityDriver);
            dashboardPage.PressPublicTableButton();
            publicTablePage = new PublicTablePage(altUnityDriver);

        }
        [Test]
        public void TestPublicTablePageLoadedCorrectly()
        {
            Assert.True(publicTablePage.IsDisplayed());
        }

        [Test]
        public void PublicTable_TC_ID_2()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_2 on click public table started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_2 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_3()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_3 to check toggle button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            LoggingScript.Instance.AddLog("Poker via Video toggle button is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_3 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_4()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_4 to check toggle button is off started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            LoggingScript.Instance.AddLog("Poker via Video toggle button is in OFF state");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_4 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_5()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_5 to check toggle button is off ON started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(6000);
            publicTablePage.PokerViaVideoToggle_tap();
            LoggingScript.Instance.AddLog("Poker via Video toggle button is switched to ON");
            Thread.Sleep(6000);
            publicTablePage.PokerViaVideoToggle_tap();
            LoggingScript.Instance.AddLog("Poker via Video toggle button is switched to OFF");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_5 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_6()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_6 to check toggle button is ON started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(6000);
            publicTablePage.PokerViaVideoToggle_tap();
            LoggingScript.Instance.AddLog("Poker via Video toggle button is switched to ON");
            LoggingScript.Instance.AddLog("List of Tables available for Video is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_6 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_7()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_7 to check toggle button is ON started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            LoggingScript.Instance.AddLog("Poker via Video toggle button is in OFF state");
            LoggingScript.Instance.AddLog("List of Tables NOT available for Video is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_7 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_8()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_8 to verify UI of public table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_8 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_9()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_9 to verify table ID started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Table ID is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_9 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_10()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_10 to verify Game name started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Game Name is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_10 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_11()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_11 to verify Stake Value started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Stake Value is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_11 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_12()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_12 to verify Min Buy-in started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Min Buy-in is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_12 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_13()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_13 to verify Max Buy-in started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Max Buy-in is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_13 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_14()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_14 to verify No of Players started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("Max number of players is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_14 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_15()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_15 to verify No of joined Players started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.IsColumnsdataDisp();
            LoggingScript.Instance.AddLog("number of players joined is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_15 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_16()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_16 to verify Observe Button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_16 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_17()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_17 to verify Gameboard UI started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsBoardDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_17 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_18()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_18 to verify Table ID started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsBoardDisplayed();
            LoggingScript.Instance.AddLog("Table ID is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_18 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_19()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_19 to verify Menu button on Click started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.MenuButton_tap();
            LoggingScript.Instance.AddLog("Menu opened");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_18 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_20()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_20 to verify Menu options started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.MenuButton_tap();
            LoggingScript.Instance.AddLog("Menu opened");
            Thread.Sleep(50000);
            publicTablePage.IsSettingsDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_20 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_21()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_21 to verify leave table button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.MenuButton_tap();
            LoggingScript.Instance.AddLog("Menu opened");
            Thread.Sleep(50000);
            publicTablePage.Lobbyback_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_21 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_22()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_22 to verify leave table NO button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.MenuButton_tap();
            LoggingScript.Instance.AddLog("Menu opened");
            Thread.Sleep(50000);
            publicTablePage.Lobbyback_tap();
            publicTablePage.CancelButton_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_22 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_23()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_23 to verify leave table OK button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.MenuButton_tap();
            LoggingScript.Instance.AddLog("Menu opened");
            Thread.Sleep(50000);
            publicTablePage.Lobbyback_tap();
            publicTablePage.OkButton_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_23 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_24()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_24 to verify support button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_24 test passed successfully");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }


}