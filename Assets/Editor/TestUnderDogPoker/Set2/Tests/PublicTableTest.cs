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

        [Test]
        public void PublicTable_TC_ID_25()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_25 to verify support screen UI started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_25 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_26()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_26 to verify Email field started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            LoggingScript.Instance.AddLog("Email address field is filled with mail id");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_26 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_27()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_27 to submit button with blank subject screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Subject cannot be empty message recived");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_27 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_28()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_28 to submit button with blank description screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.Subjectfill();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Description cannot be empty message recived");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_28 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_29()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_29 to submit button with all field fill started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.Subjectfill();
            publicTablePage.Decriptionfill();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Back to gameplay screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_29 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_30()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_30 to click on back button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.SupportBack_tap();
            LoggingScript.Instance.AddLog("Back to gameplay screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_30 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_31()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_31 to chat button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.chatButton_tap();
            LoggingScript.Instance.AddLog("chat pop up is opened");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_31 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_32()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_32 to send button in chat started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.chatButton_tap();
            LoggingScript.Instance.AddLog("chat pop up is opened");
            publicTablePage.chatsend_tap();
            LoggingScript.Instance.AddLog("Able to send message");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_32 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_35()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_35 to verify all UI buttons started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsUserUIDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_35 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_37()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_37 to verify Join button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_37 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_38()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_38 to verify Gameboard UI started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsBoardDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_38 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_39()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_39 to verify table ID started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsBoardDisplayed();
            LoggingScript.Instance.AddLog("Table ID is present");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_39 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_40()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_40 to verify the text when one player joined started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            LoggingScript.Instance.AddLog("Waiting for other players to Join to start the game - message recieved");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_40 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_41()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_41 to verify the pot value at staring the game started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsPotAmountDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_41 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_42()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_42 to verify the behaviour of + button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_42 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_43()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_43 to verify the chips balance in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("Total chipls balance is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_43 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_44()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_44 to verify the + and - button in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("+ and - buttons are displayed");
            publicTablePage.plusMinus_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_44 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_45()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_45 to verify the selected pot amount in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("selected pot amount is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_45 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_46()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_46 to verify the value of stakes in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("value of stakes is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_46 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_47()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_47 to verify the amount of min/max pot in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("amount of min/max pot is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_47 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_48()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_48 to verify the auto buy option in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            publicTablePage.autobuyin_tap();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_48 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_49()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_49 to verify the auto buy on click in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            publicTablePage.autobuyin_tap();
            LoggingScript.Instance.AddLog("auto buy is selected");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_49 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_50()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_50 to verify the buy in at max option in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("buy in at max is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_50 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_51()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_51 to verify the buy in at max option on click in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("buy in at max is displayed");
            publicTablePage.maxbuyinbox_tap();
            LoggingScript.Instance.AddLog("buy in at max is selected");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_51 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_52()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_52 to verify the UI of back button in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("back button is displayed");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_52 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_53()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_53 to verify the behaviour of back button in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            LoggingScript.Instance.AddLog("back button is displayed");
            publicTablePage.backbtnholdem_tap();
            LoggingScript.Instance.AddLog("Back to gameplay screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_53 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_54()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_54 to verify the play now button in holdem table screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.Chairjoin_tap();
            LoggingScript.Instance.AddLog("inside Hold'em table screen to choose options");
            publicTablePage.IsholdemDisplayed();
            publicTablePage.playnow_tap();
            LoggingScript.Instance.AddLog("redirects to gameplay screen and player will be in the position");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_54 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_59()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_59 to verify click on rule button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_59 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_60()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_60 to verify the rules in the rule table started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_60 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_61()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_61 to verify the table name started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Table name is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_61 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_62()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_62 to verify the game type started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Game type is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_62 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_63()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_63 to verify the game Limit started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Game Limit is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_63 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_64()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_64 to verify the turn time started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Turn time is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_64 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_65()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_65 to verify the Ante feature started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Ante Feature is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_65 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_66()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_66 to verify the Ante Amount started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Ante Amount is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_66 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_67()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_67 to verify the Rake feature started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Rake Feature is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_67 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_68()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_68 to verify the Rake percentage started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Rake Percentage is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_68 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_69()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_69 to verify the value of stakes started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Value of stakes is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_69 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_70()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_70 to verify the Min buy started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Min buy is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_70 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_71()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_71 to verify the Max buy started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Max buy is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_71 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_72()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_72 to verify the Disconnection time started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Disconnection time is available");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_72 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_73()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_73 to verify the no. of raises in the table rule started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.RuleButton_tap();
            LoggingScript.Instance.AddLog("Table rules is showing");
            publicTablePage.IsRuleTableDisplayed();
            LoggingScript.Instance.AddLog("Number of Raises is available in the Rule table");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_73 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_94()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_94 to verify the UI of all buttons started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.JoinButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.IsUserUIDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_94 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_98()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_98 to verify support screen UI started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_98 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_99()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_99 to verify Email field started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            LoggingScript.Instance.AddLog("Email address field is filled with mail id");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_99 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_100()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_100 to submit button with blank subject screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Subject cannot be empty message recived");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_100 test passed successfully");
        }


        [Test]
        public void PublicTable_TC_ID_101()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_101 to submit button with blank description screen started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.Subjectfill();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Description cannot be empty message recived");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_101 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_102()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_102 to submit button with all field fill started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.Subjectfill();
            publicTablePage.Decriptionfill();
            publicTablePage.SupportSubmitButton_tap();
            LoggingScript.Instance.AddLog("Back to gameplay screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_102 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_103()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_103 to click on back button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.SupportButton_tap();
            publicTablePage.IsSupportUIDisplayed();
            publicTablePage.SupportBack_tap();
            LoggingScript.Instance.AddLog("Back to gameplay screen");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_103 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_104()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_104 to chat button started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.chatButton_tap();
            LoggingScript.Instance.AddLog("chat pop up is opened");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_104 test passed successfully");
        }

        [Test]
        public void PublicTable_TC_ID_105()
        {
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_105 to send button in chat started execution");
            Assert.True(publicTablePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Inside public table list screen");
            Thread.Sleep(5000);
            publicTablePage.ObserverButton_tap();
            LoggingScript.Instance.AddLog("Inside game");
            Thread.Sleep(10000);
            publicTablePage.chatButton_tap();
            LoggingScript.Instance.AddLog("chat pop up is opened");
            publicTablePage.chatsend_tap();
            LoggingScript.Instance.AddLog("Able to send message");
            LoggingScript.Instance.AddLog("PublicTable_TC_ID_105 test passed successfully");
        }


        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }


}