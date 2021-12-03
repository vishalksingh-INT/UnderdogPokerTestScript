using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;

namespace Editor.TestUnderDogPoker.Pages
{
    public class ForgotPasswordPage : BasePage
    {
        LoginPage loginPage;
        public ForgotPasswordPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard");
        }

        //ForgotPassword_Panel
        public AltUnityObject ForgotPasswordTextField { get => Driver.WaitForObject(By.NAME, "ForgotPasswordTextField"); }
        public AltUnityObject OKAY_Button { get => Driver.WaitForObject(By.NAME, "OKAY_Button"); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton"); }
        public AltUnityObject SubmitOTPButton { get => Driver.WaitForObject(By.NAME, "Submit_OTP_Button"); }
        public AltUnityObject OTPTextField { get => Driver.WaitForObject(By.NAME, "ForgotPasswordOTP_TextField"); }
        //Reset&ConfirmPassword_Panel
        //NEwPassword_TextField
        //ConfirmPassword_TextField
        //Confirm_Button
        public AltUnityObject NewPasswordTextField { get => Driver.WaitForObject(By.NAME, "NEwPassword_TextField"); }
        public AltUnityObject ConfirmPasswordTextField { get => Driver.WaitForObject(By.NAME, "ConfirmPassword_TextField"); }
        public AltUnityObject ConfirmButton { get => Driver.WaitForObject(By.NAME, "Confirm_Button"); }
        //ErrorMessage_Panel
        
            
        public AltUnityObject ErrorMessage_Panel { get => Driver.WaitForObject(By.NAME, "ErrorMessage_Panel"); }
        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton"); }
        public AltUnityObject Text { get => Driver.WaitForObject(By.NAME, "Text"); }
        public AltUnityObject Err_Text { get => Driver.WaitForObject(By.NAME, "ErrorMessage_Panel/Error_text"); }
        public AltUnityObject RetryButton { get => Driver.WaitForObject(By.NAME, "RetryButton"); }
        //RetryButton  No account found with this email address.
        public bool IsDisplayed()
        {
            if (ForgotPasswordTextField != null && OKAY_Button != null && BackButton != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Forgot password screen loaded successfully");
            }
                return false;
        }

        public void SetEmailID()
        {
            ForgotPasswordTextField.SetText("srinivasarao.nelluri@indusnet.com");
            LoggingScript.Instance.AddLog("Entered email into emai input field");
        }
        public void PressOkayButton()
        {
            OKAY_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Okay button");

        }
        public void PressBackButton()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on back button");
        }

        public void SetOTP()
        {
            OTPTextField.SetText("0gynaWMennSMfo4uQkydugIERrZ6VThm");
            LoggingScript.Instance.AddLog("Entered OTP in OTP field");
        }

        public void PressSubmitButton()
        {
            SubmitOTPButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Submit button");
        }
        public void CreaatePassword()
        {
            NewPasswordTextField.SetText("Srinivas@321");
            LoggingScript.Instance.AddLog("Entered New password in new password field");
           
            ConfirmPasswordTextField.SetText("Srinivas@321");
            LoggingScript.Instance.AddLog("Entered Confirm password in confirm password field");
            ConfirmButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on confirm button");

        }

        public void LoginEmail()
        {

            loginPage.EmailIdInput.SetText("srinivas@gmail.com");
            LoggingScript.Instance.AddLog("Entered email into emai input field");

            loginPage.PasswordInput.SetText("Srinivas@123");
            LoggingScript.Instance.AddLog("Entered password into password field");

            loginPage.LoginBtn.Tap();

            LoggingScript.Instance.AddLog("Clicked on login button");


        }


        //password when passing only numbers
        public void passwordpassing_numbers()
        {
            NewPasswordTextField.SetText("123121");

            LoggingScript.Instance.AddLog("Entered numbers in new password field");
            ConfirmPasswordTextField.SetText("123121");

            LoggingScript.Instance.AddLog("Entered numbers in confirm password field");
            ConfirmButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on confirm button");
        }
        public void errormessage_password_confirmpassword_notmatches()
        {
            NewPasswordTextField.SetText("srinivas@123");
            LoggingScript.Instance.AddLog("Entered password in new password field");

            ConfirmPasswordTextField.SetText("Srinivas");
            LoggingScript.Instance.AddLog("Entered mismatch password in confirm password field");

            ConfirmButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on confirm button");
        }
        public bool CreaatePasswordIsDisplayed()
        {
            if (NewPasswordTextField != null && ConfirmPasswordTextField != null && ConfirmButton != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Create password screen loaded successfully");
            }
            return false;
        }

        public bool isDisplayalert()
        {
            if (ErrorMessage_Panel.enabled)
            {
                return true;
                LoggingScript.Instance.AddLog("alert message is displayed");
            }
            return false;
        }

        public string getAlertText()
        {
            LoggingScript.Instance.AddLog("Returned the alert message text");
            return Err_Text.GetText();
        }

        public void notfillingdata()
        {
            PressOkayButton();
            LoggingScript.Instance.AddLog("Clicked on Okay button without filling data");
        }
        //passing Invalid Email ID
        public void passingInvalidEmailID()
        {
            ForgotPasswordTextField.SetText("srinivasarao.nelluri@com");
            LoggingScript.Instance.AddLog("Entered invalid emailid ");
        }

        //
        public void entersnotregisteredemailid()
        {
            ForgotPasswordTextField.SetText("srinivasarao.nelluri@gmail.com");
            LoggingScript.Instance.AddLog("Enter not registered emailid");
        }
    }
}