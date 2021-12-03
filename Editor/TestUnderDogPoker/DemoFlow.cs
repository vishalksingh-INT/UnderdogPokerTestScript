using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker
{
    public class DemoFlow : IDisposable
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
        private EmailSignupPage emailSignupPage;
        private WelcomeBonusRewardPage welcomeBonusRewardPage;
        private NickNamePage nickNamePage;

        public DemoFlow()
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
            emailSignupPage = new EmailSignupPage(altUnityDriver);
            welcomeBonusRewardPage = new WelcomeBonusRewardPage(altUnityDriver);
            nickNamePage = new NickNamePage(altUnityDriver);
        }
        public void Dispose()
        {
            altUnityDriver.Stop();

        }

        [Test]
        public void TC01Signup_TC_ID_1_2SignupPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_1 is started execution");

            Assert.True(signupPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_1 is passed");

        }

       
        [Test]
        public void TC02Signup_TC_ID_9_10LoadEmailSignupScreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_9 is started execution");
            signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_9 is passed");
        }
        [Test]
        public void TC03Signup_TC_ID_11_Name_cannot_be_empty_AlertMessage()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_11_Name_cannot_be_empty_AlertMessage started execution");
            //signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            
            emailSignupPage.EmailRegFormNamealertMessage();
            Console.WriteLine(emailSignupPage.GetErorrMessageText());
            LoggingScript.Instance.AddLog(emailSignupPage.GetErorrMessageText());
            //string text= emailSignupPage.GetErorrMessageText(),
            Assert.AreEqual("Name cannot be empty.", emailSignupPage.GetErorrMessageText());
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_11_Name_cannot_be_empty_AlertMessage Ended execution");



        }
        public void TC04Signup_TC_ID_12Email_cannot_be_emptyMessage()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_12Email_cannot_be_emptyMessage started execution");
            signupPage.ClickEmailSignupButton();
            Assert.True(emailSignupPage.IsDisplayed());
            
            emailSignupPage.EmailRegFormEmailalertMessage();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Email cannot be empty");
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_12Email_cannot_be_emptyMessage ended execution");

        }
        [Test]
        public void TC05Signup_TC_ID_13Password_cannot_be_emptyMessage()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_13Password_cannot_be_emptyMessage started execution");
            //signupPage.ClickEmailSignupButton();
            // Assert.True(emailSignupPage.IsDisplayed());

            emailSignupPage.EmailRegFormPasswordalertMessage();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password cannot be empty.");
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_13Password_cannot_be_emptyMessage ended execution");
        }

       
        [Test]
        public void TC06Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen started execution");

            emailSignupPage.EmailRegFormPasswordalertMessage();

            // Assert.AreEqual(emailSignupPage.GetOkayButtonText(), "OkayButton");

            emailSignupPage.PressOkayButton();
            Assert.True(emailSignupPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_15_19_afterclickingOkaybutton_redirect_emaisignupscreen ended execution");
        }
        //existing Username
        public void TC07Signup_TC_ID_16_existingUsernamee()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_16_existingUsername started execution");

            emailSignupPage.existingUsername();

            Assert.AreEqual(emailSignupPage.GetwrongnameMessageText(), "This username is already exists");
            //emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_16_existingUsername ended execution");
        }
        //
        [Test]
        public void TC08Signup_TC_ID_20_existingemailid()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_20_existingemailid started execution");
            emailSignupPage.ExistingEmailid();

            Assert.AreEqual(emailSignupPage.GetWrongEmail_Text(), "This E-mail already exists.");
            //emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_20_existingemailid ended execution");
        }

        [Test]
        public void TC09Signup_TC_ID_23_password_limit_Min()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_Min started execution");

            emailSignupPage.PasswordLimitMin();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password must contain a minimum of 1 upper, lower and numeric character");
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_23_password_limit_Min ended execution");
        }
        
        [Test]
        public void TC10Signup_TC_ID_25_Passwordonlynumbers()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_25_Passwordonlynumbers started execution");

            emailSignupPage.Passwordonlynumbers();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Password must contain a minimum of 1 upper, lower and numeric character");
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_25_Passwordonlynumbers ended execution");
        }

        [Test]
        public void TC11Signup_TC_ID_26_EmailRegForm()
        {
            LoggingScript.Instance.AddLog("EmailRegForm started execution");

            emailSignupPage.EmailRegForm();

            //Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Congratulation you have been successfully registered");
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("EmailRegForm ended execution");
        }

        [Test]
        public void Signup_TC_ID_30_withoutAgreeterms()
        {

            LoggingScript.Instance.AddLog("Signup_TC_ID_30_withoutAgreeterms started execution");
            emailSignupPage.withoutAgreeterms();

            Assert.AreEqual(emailSignupPage.GetErorrMessageText(), "Please accept our terms and condition");
            //Please agree to T&C.
            emailSignupPage.PressOkayButton();
            LoggingScript.Instance.AddLog("Signup_TC_ID_30_withoutAgreeterms ended execution");

        }


        [Test]
        public void Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen started execution");
            emailSignupPage.PressLoginHereButton();
            //signupPage.PressLoginHereButton();
            Assert.True(loginPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_32_afterclickingLoginherebutton_redirect_loginscreen ended execution");

        }

        [Test]
        public void Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen started execution");
            emailSignupPage.EmailRegForm();
            emailSignupPage.PressOkayButton();

            Assert.True(welcomeBonusRewardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_33_34_35_aftersignup_redirect_WelcomeBonusScreen ended execution");
        }

        [Test]
        public void TC12Signup_TC_ID_41_42_CliamButtonLoadNickName()
        {
            LoggingScript.Instance.AddLog("TC12Signup_TC_ID_41_42_CliamButtonLoadNickName started execution");
            welcomeBonusRewardPage.PressClaimButton();
            Assert.True(nickNamePage.IsDisplayed());
            LoggingScript.Instance.AddLog("TC12Signup_TC_ID_41_42_CliamButtonLoadNickName ended execution");
        }

        [Test]
        public void TC13Login_TC_ID_23_NamePageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("Login_TC_ID_23_NamePageLoadedCorrectly started execution");
            Assert.True(nickNamePage.IsDisplayed());
            LoggingScript.Instance.AddLog("Login_TC_ID_23_NamePageLoadedCorrectly ended execution");
        }


       
        [Test]
        public void TC14Signup_TC_ID_43_SetNickName()
        {
            LoggingScript.Instance.AddLog("Signup_TC_ID_43_SetNickName started execution");
            nickNamePage.SetNickName();
            
            nickNamePage.PressOkayButtonNickName();
            //  Assert.True(emailSignupPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Signup_TC_ID_43_SetNickName ended execution");

        }
        [Test]
        public void TC15tDailyRewardPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("DailyRewardPageLoadedCorrectly started execution");
            Assert.True(welcomeDailyRewardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("DailyRewardPageLoadedCorrectly ended execution");
        }
        [Test]
        public void TC16BackButtonLoadDashboard()
        {
            LoggingScript.Instance.AddLog("BackButtonLoadDashboard started execution");
            welcomeDailyRewardPage.PressDailyBonusBackButton();
            Assert.True(dashboardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("BackButtonLoadDashboard ended execution");
        }

        [Test]
        public void TC17Dashboard_TC_ID_1_DashboardPageLoadedCorrectly()
        {
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_1_DashboardPageLoadedCorrectly started execution");
            Assert.True(dashboardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_1_DashboardPageLoadedCorrectly ended execution");
        }


        [Test]
        public void TC18Dashboard_TC_ID_6_Hembergermenu()
        {
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_6_Hembergermenu started execution");
            dashboardPage.PressHambergarMenu();

            Assert.True(hambergarMenuPage.IsDisplayed());
            LoggingScript.Instance.AddLog("Dashboard_TC_ID_6_Hembergermenu ended execution");
        }

        [Test]
        public void TC19SettingsDisplayedCorrectly()

        {
            LoggingScript.Instance.AddLog("SettingsDisplayedCorrectly started execution");
            hambergarMenuPage.PressSettingsButton();
            Assert.True(settingsPage.IsDisplayed());
            LoggingScript.Instance.AddLog("SettingsDisplayedCorrectly ended execution");
        }
        [Test]
        public void TC20PressSettingsBackButtonLoadDashBoard()
        {
            LoggingScript.Instance.AddLog("PressSettingsBackButtonLoadDashBoard started execution");
            settingsPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("PressSettingsBackButtonLoadDashBoard ended execution");
        }
        [Test]
        public void TC21PressNotificationButtonLoadNotificationScreen()
        {
            LoggingScript.Instance.AddLog("PressNotificationButtonLoadNotificationScreen started execution");
            dashboardPage.PressNotificationButton();
            Assert.True(notificationPage.IsDisplayed());
            LoggingScript.Instance.AddLog("PressNotificationButtonLoadNotificationScreen ended execution");

        }
        [Test]
        public void TC22PressNotBackButtonLoadDashBoard()
        {
            LoggingScript.Instance.AddLog("PressNotBackButtonLoadDashBoard started execution");
            notificationPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
            LoggingScript.Instance.AddLog("PressNotBackButtonLoadDashBoard ended execution");
        }
        [Test]
        public void TC23PressREWButtonLoadREWARDScreen()
        {
            dashboardPage.PressRewardButton();
            Thread.Sleep(2000);
            Assert.True(welcomeDailyRewardPage.IsDisplayed());

        }
        [Test]
        public void TC24PressREWBackButtonLoadDashBoard()
        {
            welcomeDailyRewardPage.PressDailyBonusBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void TC25PressShopButtonLoadShopScreen()
        {
            dashboardPage.PressShopButton();
            Thread.Sleep(2000);
            Assert.True(shopPage.IsDisplayed());

        }
        [Test]
        public void TC26PressShopBackButtonLoadDashBoard()
        {
            shopPage.PressBackButton();
            Assert.True(dashboardPage.IsDisplayed());
        }
        [Test]
        public void TC27PressLogoutButton()
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