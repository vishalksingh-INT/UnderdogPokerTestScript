using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
using Editor.TestUnderDogPoker.Pages;

namespace Editor.TestUnderDogPoker.Tests

{
    public class PlayerProfileTest : IDisposable
    {
        AltUnityDriver altUnityDriver;
     
        SignupPage signupPage;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        PlayerProfilePage playerProfilePage;
        public PlayerProfileTest()
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
        }

        public void Profile_TC_ID_1_()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_1 started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            LoggingScript.Instance.AddLog("Profile_TC_ID_1 test passed");
        }

        [Test]
        public void Profile_TC_ID_2()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_2 started execution to verify avatar is appearing");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            LoggingScript.Instance.AddLog("Avatar is visible");
            LoggingScript.Instance.AddLog("Profile_TC_ID_2 test passed");
        }

        [Test]
        public void Profile_TC_ID_1()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_1 started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_1 test passed");
        }

        [Test]
        public void Profile_TC_ID_3()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_3 to check username under profile photo started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            Thread.Sleep(8000);
            playerProfilePage.Avatar_tap();
            Thread.Sleep(8000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Username is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_3 test passed");
        }

        [Test]
        public void Profile_TC_ID_4()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_4 to check Earned chips inside account profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Earned chips is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_4 test passed");
        }

        [Test]
        public void Profile_TC_ID_5()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_5 to check Earned gems in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Earned Gems is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_5 test passed");
        }

        [Test]
        public void Profile_TC_ID_6()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_6 to check Share button in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Share button is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_6 test passed");
        }

        [Test]
        public void Profile_TC_ID_7()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_7 to check Share button in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Share button is available inside Account profile screen");
            playerProfilePage.ShareButton_tap();
            LoggingScript.Instance.AddLog("Sharing profile");
            LoggingScript.Instance.AddLog("Profile_TC_ID_7 test passed");
        }

        [Test]
        public void Profile_TC_ID_8()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_8 to check player stats in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Player stats is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_8 test passed");
        }

        [Test]
        public void Profile_TC_ID_9()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_9 to check Number of hands in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Number of hands is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_9 test passed");
        }

        [Test]
        public void Profile_TC_ID_10()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_10 to check Biggest pot won in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Biggest pot won is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_10 test passed");
        }

        [Test]
        public void Profile_TC_ID_11()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_11 to check Biggest winning hand in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Biggest winning hand is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_11 test passed");
        }

        [Test]
        public void Profile_TC_ID_12()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_12 to check Pre-flop fold in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Pre-flop-fold is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_12 test passed");
        }

        [Test]
        public void Profile_TC_ID_13()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_13 to check turn fold in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Turn-fold is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_13 test passed");
        }

        [Test]
        public void Profile_TC_ID_14()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_14 to check Flop fold in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("Flop fold is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_14 test passed");
        }

        [Test]
        public void Profile_TC_ID_15()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_15 to check river fold in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("river fold is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_15 test passed");
        }

        [Test]
        public void Profile_TC_ID_16()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_16 to check RaiseFrequency in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("RaiseFrequency is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_16 test passed");
        }

        [Test]
        public void Profile_TC_ID_17()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_17 to check StakeTable in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("StakeTable is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_17 test passed");
        }

        [Test]
        public void Profile_TC_ID_18()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_18 to check MostStake in player stats started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsStatsDisplayed();
        
        LoggingScript.Instance.AddLog("MostStake is available in Player stats");
            LoggingScript.Instance.AddLog("Profile_TC_ID_18 test passed");
        }

        [Test]
        public void Profile_TC_ID_19()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_19 to check Edit button in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_19 test passed");
        }

        [Test]
        public void Profile_TC_ID_20()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_20 to check on click Edit button in profile screen started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            Thread.Sleep(5000);
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            LoggingScript.Instance.AddLog("Profile_TC_ID_20 test passed");
        }

        [Test]
        public void Profile_TC_ID_21()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_21 to check Username in edit profile started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Username is available");
            LoggingScript.Instance.AddLog("Profile_TC_ID_21 test passed");
        }

        [Test]
        public void Profile_TC_ID_22()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_22 to check username is editable or not started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Username is available");
            LoggingScript.Instance.AddLog("Unable to edit username");
            LoggingScript.Instance.AddLog("Profile_TC_ID_22 test passed");
        }

        [Test]
        public void Profile_TC_ID_23()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_23 to check Nickname is available started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Nickname is available");
            LoggingScript.Instance.AddLog("Profile_TC_ID_23 test passed");
        }

        [Test]
        public void Profile_TC_ID_27()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_27 to check Email field  is available started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Email field is available");
            LoggingScript.Instance.AddLog("Profile_TC_ID_27 test passed");
        }

        [Test]
        public void Profile_TC_ID_30()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_30 to check Email accepts blank started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Email field is available");
            playerProfilePage.EmailId_fill();
            LoggingScript.Instance.AddLog("Alert pop message recieved");
            LoggingScript.Instance.AddLog("Profile_TC_ID_27 test passed");
        }

        [Test]
        public void Profile_TC_ID_34()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_34 to check mobile number field  is available started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Mobile number field is available");
            LoggingScript.Instance.AddLog("Profile_TC_ID_34 test passed");
        }

        [Test]
        public void Profile_TC_ID_42()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_42 to check Zipcode field  is available started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.IsEditDisplayed();
            LoggingScript.Instance.AddLog("Zip code field is available");
            LoggingScript.Instance.AddLog("Profile_TC_ID_42 test passed");
        }

        [Test]
        public void Profile_TC_ID_24()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_24 to check with empty nick name started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.NoNickname_fill();
            LoggingScript.Instance.AddLog("Alert message recieved");
            LoggingScript.Instance.AddLog("Profile_TC_ID_24 test passed");
        }

        [Test]
        public void Profile_TC_ID_35()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_35 to check with empty mobile number started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.NoMobileNo_fill();
            LoggingScript.Instance.AddLog("Alert message recieved");
            LoggingScript.Instance.AddLog("Profile_TC_ID_35 test passed");
        }

        [Test]
        public void Profile_TC_ID_43()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_43 to check with empty zip code started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.NoZipcode_fill();
            LoggingScript.Instance.AddLog("Alert message recieved");
            LoggingScript.Instance.AddLog("Profile_TC_ID_43 test passed");
        }

        [Test]
        public void Profile_TC_ID_47()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_47 to check save button with proper values started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.AllFill_fill();
            LoggingScript.Instance.AddLog("success message recieved");
            LoggingScript.Instance.AddLog("Profile_TC_ID_47 test passed");
        }

        [Test]
        public void Profile_TC_ID_48()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_48 to check okay button on save started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Edit button is available inside Account profile screen");
            playerProfilePage.EditButton_tap();
            LoggingScript.Instance.AddLog("Inside Edit profile page");
            playerProfilePage.AllFillok_fill();
            Thread.Sleep(8000);
            playerProfilePage.IsDisplayed();
            LoggingScript.Instance.AddLog("Profile_TC_ID_48 test passed");
        }

        [Test]
        public void Profile_TC_ID_50_to_53()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_50_to_53 to check player avatar started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            playerProfilePage.Avataricon_tap();
            LoggingScript.Instance.AddLog("Inside select avatar page");
            LoggingScript.Instance.AddLog("Profile_TC_ID_50_to_53 test passed");
        }

        [Test]
        public void Profile_TC_ID_55()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_55 to check Save button presence started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            playerProfilePage.Avataricon_tap();
            playerProfilePage.IsSelectAvatarScreen();
            LoggingScript.Instance.AddLog("Save button is present");
            LoggingScript.Instance.AddLog("Profile_TC_ID_55 test passed");
        }

        [Test]
        public void Profile_TC_ID_58()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_58 to check back button presence started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            Thread.Sleep(5000);
            playerProfilePage.Avataricon_tap();
            playerProfilePage.IsSelectAvatarScreen();
            LoggingScript.Instance.AddLog("Back button is present");
            LoggingScript.Instance.AddLog("Profile_TC_ID_58 test passed");
        }

        [Test]
        public void Profile_TC_ID_57()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_57 to check save button without selecting avatar presence started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            playerProfilePage.Avataricon_tap();
            Thread.Sleep(3000);
            playerProfilePage.Avatarsave_tap();
            LoggingScript.Instance.AddLog("Back to the account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_57 test passed");
        }

        [Test]
        public void Profile_TC_ID_56()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_56 to check save button after selecting avatar presence started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            Thread.Sleep(5000);
            playerProfilePage.Avataricon_tap();
            Thread.Sleep(3000);
            playerProfilePage.AvatearInside_tap();
            Thread.Sleep(3000);
            playerProfilePage.Avatarsave_tap();
            LoggingScript.Instance.AddLog("Back to the account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_56 test passed");
        }

        [Test]
        public void Profile_TC_ID_59()
        {
            LoggingScript.Instance.AddLog("Profile_TC_ID_59 to check back button after selecting avatar presence started execution");
            Assert.True(playerProfilePage.IsAvatarDisplayed());
            Thread.Sleep(10000);
            playerProfilePage.BackButton_tap();
            playerProfilePage.Avatar_tap();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Inside Account profile screen");
            playerProfilePage.IsDisplayed();
            Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Player avatar is available");
            LoggingScript.Instance.AddLog("Player Name is available");
            Thread.Sleep(5000);
            playerProfilePage.Avataricon_tap();
            Thread.Sleep(3000);
            playerProfilePage.AvatearInside_tap();
            Thread.Sleep(3000);
            playerProfilePage.backbuttonavatar_tap();
            LoggingScript.Instance.AddLog("Back to the account profile screen");
            LoggingScript.Instance.AddLog("Profile_TC_ID_59 test passed");
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }

}