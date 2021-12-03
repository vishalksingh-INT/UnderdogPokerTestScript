using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;

namespace Editor.TestUnderDogPoker.Pages
{
    public class SignupPage : BasePage
    {
        public SignupPage(AltUnityDriver driver) : base(driver)
        {
        }
        public void Load()
        {
            Driver.LoadScene("Dashboard", true);
            LoggingScript.Instance.AddLog("Dashboard loaded sucessfully");
            Thread.Sleep(9000);
           // UnityEngine.GameObject.Find("RegistrationOption_Panel").SetActive(true);
           // Assert.IsTrue(RegistrationOptionPanel.enabled);
        }

       /* public AltUnityObject ShopButton { get => Driver.WaitForObject(By.NAME, "Shop_Button", timeout: 2); }
        public AltUnityObject RewardButton { get => Driver.WaitForObject(By.NAME, "Freereward_Button", timeout: 2); }

        public AltUnityObject NotificationButton { get => Driver.WaitForObject(By.NAME, "Notification_Button", timeout: 2); }
*/
        //Registration options
       // public AltUnityObject RegistrationOptionPanel { get => Driver.WaitForObject(By.NAME, "RegistrationOption_Panel"); }
        public AltUnityObject GoogleSignUpBtn { get => Driver.WaitForObject(By.NAME, "Google_SignUp_Btn"); }
        public AltUnityObject FBSignUpBtn { get => Driver.WaitForObject(By.NAME, "FB_SignUp_Btn"); }
        public AltUnityObject EmailSignUpBtn { get => Driver.WaitForObject(By.NAME, "Email_SignUp_Btn"); }

        public AltUnityObject LoginHerebtn { get => Driver.WaitForObject(By.NAME, "LoginHere_btn (1)"); }

       

        //Welcome BonusReward_Panel
        //Welcome_Image
        //YouGot_Text

        //2ItemsContainer
        //Item1Img
        //Item2Img
        //Bonus1_Text
        //Bonus2_Text


        //public AltUnityObject Claim_btn { get => Driver.WaitForObject(By.NAME, "ClaimButton"); }
      // string Claim_btn = "ClaimButton";
        //ClaimButton



        //ForgotPassword_Panel
        public AltUnityObject ForgotPasswordTextField { get => Driver.WaitForObject(By.NAME, " ForgotPasswordTextField"); }
        public AltUnityObject OKAY_Button { get => Driver.WaitForObject(By.NAME, "OKAY_Button"); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton"); }


        //ForgotPassword_Error_Panel

        public AltUnityObject RetryButton { get => Driver.WaitForObject(By.NAME, "RetryButton"); }
        public bool IsDisplayed()
        {
            if (GoogleSignUpBtn != null && FBSignUpBtn != null && EmailSignUpBtn != null && LoginHerebtn != null)
            {
                LoggingScript.Instance.AddLog("Dashboard loaded sucessfully with all options");
                return true;
            }
            return false;
            
        }
        public void ClickEmailSignupButton()
        {     
            
            EmailSignUpBtn.Tap();
            //Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Clicked on Email Signup Button");
        }

        public void ClickgoogleSignupButton()
        {

            GoogleSignUpBtn.Tap();
            //Thread.Sleep(5000);
            LoggingScript.Instance.AddLog("Clicked on google Signup Button");
        }
        public string GetEmailSignupButtonText()
        {
            return EmailSignUpBtn.GetText();
        }

       public void PressLoginHereButton()
        {
            LoginHerebtn.Tap();

            LoggingScript.Instance.AddLog("Clicked on Login Here button");
        }
        public string GetLoginHereButtonText()
        {
            return LoginHerebtn.GetText();
        }

        public void PressGoogleSignUpButton()
        {
            GoogleSignUpBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on google Signup Button");

        }
        public string GetGoogleSignUpButtonText()
        {
            return GoogleSignUpBtn.GetText();
        }
        public void PressFBSignUpButton()
        {
            FBSignUpBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Facebook Signup Button");

        }
        public string GetFBSignUpButtonText()
        {
            return FBSignUpBtn.GetText();
        }
        public void PressOKAY_Button()
        {
            OKAY_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Okay Button");

        }
        public void PressBackButton()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Back Button");

        }






    }
}