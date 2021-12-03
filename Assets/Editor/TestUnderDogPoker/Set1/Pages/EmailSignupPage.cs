using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;

namespace Editor.TestUnderDogPoker.Pages
{
    public class EmailSignupPage : BasePage
{
    public EmailSignupPage(AltUnityDriver driver) : base(driver)
    {
    }
    public void LoadScene()
    {
        Driver.LoadScene("Dashboard",true);
    }

        //Email registratin Email_Registration_Panel/
        public AltUnityObject EmailInput { get => Driver.WaitForObject(By.NAME, "Email"); }
        public AltUnityObject UserName { get => Driver.WaitForObject(By.NAME, "Name"); }
        public AltUnityObject Password { get => Driver.WaitForObject(By.NAME, "Password"); }
        
        public AltUnityObject Refferal { get => Driver.WaitForObject(By.NAME, "Refferal"); }
        // public AltUnityObject Agree { get => Driver.WaitForObject(By.NAME, "Agree_T&C"); }
        //Label
        public AltUnityObject Agree { get => Driver.WaitForObject(By.NAME, "Label"); }
        public AltUnityObject REGISTER_Button { get => Driver.WaitForObject(By.NAME, "REGISTER_Button"); }
        public AltUnityObject LoginHere_btn { get => Driver.WaitForObject(By.NAME, "LoginHere_btn"); }
        //WrongUserName_Text
        public AltUnityObject WrongUserName_Text { get => Driver.WaitForObject(By.NAME, "WrongUserName_Text"); }
        //WrongEmail_Text
        public AltUnityObject WrongEmail_Text { get => Driver.WaitForObject(By.NAME, "WrongEmail_Text"); }

        //ErrorMessage_Panel
        public AltUnityObject ErrorText { get => Driver.WaitForObject(By.NAME, "ErrorMessage_Panel"); }
        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton"); }
        public AltUnityObject Error_text { get => Driver.WaitForObject(By.NAME, "Error_text"); }
        

        public bool IsDisplayed()
    {
            Thread.Sleep(2000);
            if (EmailInput != null && UserName != null && Refferal != null && Password != null && REGISTER_Button != null && LoginHere_btn != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Email signup screen loaded successfully");
            }
                return false;
    }
        public void EmailRegForm()
        {
           
            UserName.SetText("Do022w13");
            LoggingScript.Instance.AddLog("Entered the user name");
            
            EmailInput.SetText("Do022w451@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            
            Password.SetText("Sd@1231w4");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
           
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }
       
        public void EmailRegFormNamealertMessage()

        {
            

            EmailInput.SetText("srinivas112@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            Thread.Sleep(2000);
            Password.SetText("Srinivas@1234");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
            //Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            Thread.Sleep(2000);
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");
        }
        public void EmailRegFormEmailalertMessage()
        {
            Thread.Sleep(5000);
            UserName.SetText("Srinivas1234");
            LoggingScript.Instance.AddLog("Entered the user name");
            Thread.Sleep(2000);
            EmailInput.SetText("");
            LoggingScript.Instance.AddLog("Entered the Email");
            Thread.Sleep(2000);
            Password.SetText("Srinivas@123");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            Thread.Sleep(2000);
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }
        public void EmailRegFormPasswordalertMessage()
        {
            Thread.Sleep(5000);
            UserName.SetText("Srinivas1234");
            LoggingScript.Instance.AddLog("Entered the user name");
           
            EmailInput.SetText("srinivas1234@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            
            Password.SetText("");
            LoggingScript.Instance.AddLog("not Entered the password");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            Thread.Sleep(2000);
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }

        public string GetErorrMessageText()
        {
            return Error_text.GetText();
            LoggingScript.Instance.AddLog("Returned the alert message text");

        }
        public string GetwrongnameMessageText()
        {
            return WrongUserName_Text.GetText();
            LoggingScript.Instance.AddLog("Returned the wrong user name message text");

        }
        //
        public string GetWrongEmail_Text()
        {
            return WrongEmail_Text.GetText();
            LoggingScript.Instance.AddLog("Returned the wrong email message text");

        }
        public string GetOkayButtonText()
        {
            LoggingScript.Instance.AddLog("returned okay text");

            return OkayButton.GetText();
        }
        public void PressOkayButton()
        {
            OkayButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Okay button button");

        }

        public void PressLoginhereButton()
        {
            LoginHere_btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Login here button");

        }
        public void PressLoginHereButton()
        {
            LoginHere_btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Login here button");

        }

        public void existingUsername()
        {
            //enter existing user name
            UserName.SetText("Srinivas");
            LoggingScript.Instance.AddLog("Entered the user name");
            
            EmailInput.SetText("srinivas1234@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            
            Password.SetText("Srinivas@123");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            Thread.Sleep(2000);
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }
        public void ExistingEmailid()
        {
            
            UserName.SetText("Sriniva0001");
            LoggingScript.Instance.AddLog("Entered the user name");
            
            EmailInput.SetText("srinivas@gmail.com");
            LoggingScript.Instance.AddLog("Entered the existing Email");
            
            Password.SetText("Srinivas@123");
            LoggingScript.Instance.AddLog("Entered the password");
            
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }

        public void PasswordLimitMin()
        {
            
            UserName.SetText("Srinivas123456");
            LoggingScript.Instance.AddLog("Entered the user name");
           
            EmailInput.SetText("srinivas1122@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            
            Password.SetText("123");
            LoggingScript.Instance.AddLog("Entered the password min caracters");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
            
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }
        public void PasswordLimitMax()
        {
           
            UserName.SetText("Srinivas123");
            LoggingScript.Instance.AddLog("Entered the user name");
           
            EmailInput.SetText("srinivas11232@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");
            
            Password.SetText("23456789wertyuicvghjkldfghrtyuicvbnfghcv345678");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");
         
            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }

        public void Passwordonlynumbers()
        {

            UserName.SetText("Srinivas12345");
            LoggingScript.Instance.AddLog("Entered the user name");

            EmailInput.SetText("srinivas1212@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");

            Password.SetText("23456789345678");
            LoggingScript.Instance.AddLog("Entered the password");
            //Refferal.SetTest("Referalcoe");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");

            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }

        public void incorrectReferralcode()
        {

            UserName.SetText("Demo123");
            LoggingScript.Instance.AddLog("Entered the user name");

            EmailInput.SetText("demo123@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");

            Password.SetText("Demo123@123");
            LoggingScript.Instance.AddLog("Entered the password");
            Refferal.SetText("Referalcode");
            LoggingScript.Instance.AddLog("Entered the wrong Referal code");
            Agree.Tap();
            LoggingScript.Instance.AddLog("Clicked on agree button");

            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }

        public void withoutAgreeterms()
        {

            UserName.SetText("Srinivas123");
            LoggingScript.Instance.AddLog("Entered the user name");

            EmailInput.SetText("srinivas12123@gmail.com");
            LoggingScript.Instance.AddLog("Entered the Email");

            Password.SetText("Password@123");
            LoggingScript.Instance.AddLog("Entered the password");
            Refferal.SetText("test001");
            LoggingScript.Instance.AddLog("Entered the wrong Referal code");
          //  Agree.Tap();
            //LoggingScript.Instance.AddLog("Clicked on agree button");

            REGISTER_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Registration button");


        }



    }
}
