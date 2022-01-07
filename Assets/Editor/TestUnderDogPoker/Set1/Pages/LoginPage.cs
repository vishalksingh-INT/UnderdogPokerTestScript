using NUnit.Framework;
using Altom.AltUnityDriver;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;
using System;

public class LoginPage : BasePage
{
    public LoginPage(AltUnityDriver driver) : base(driver)
    {
    }
    public void Load()
    {
        Driver.LoadScene("Dashboard");

        Thread.Sleep(2000);
        LoggingScript.Instance.AddLog("Dashboard loaded sucessfylly");
    }

    //public AltUnityObject LoginHerebtn { get => Driver.WaitForObject(By.TEXT, "Login Here"); }

    //EmailLoginScript
    //Email

    public AltUnityObject EmailIdInput { get => Driver.WaitForObject(By.NAME, "Email"); }
    public AltUnityObject PasswordInput { get => Driver.WaitForObject(By.NAME, "Password"); }
    public AltUnityObject LoginBtn { get => Driver.WaitForObject(By.NAME, "LOGIN_Btn"); }
    public AltUnityObject Google_SignIn_Btn { get => Driver.WaitForObject(By.NAME, "Google_SignIn_Btn"); }
    public AltUnityObject FB_SignIn_Btn { get => Driver.WaitForObject(By.NAME, "FB_SignIn_Btn"); }
    public AltUnityObject ForgotPwd_Btn { get => Driver.WaitForObject(By.NAME, "ForgotPwd_Btn"); }

    public AltUnityObject CreateNow_Btn { get => Driver.WaitForObject(By.NAME, "CreateNow_Btn"); }

    //ErrorMessage_Panel
    public AltUnityObject Text { get => Driver.WaitForObject(By.NAME, "Text"); }
    public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton"); }
    public AltUnityObject ErrorMessage_Panel { get => Driver.WaitForObject(By.NAME, "ErrorMessage_Panel"); }
    public AltUnityObject Error_text { get => Driver.WaitForObject(By.NAME, "Error_text"); }

    public AltUnityObject PopUp_text { get => Driver.WaitForObject(By.NAME, "Text_2"); }

    public AltUnityObject RetryButton { get => Driver.WaitForObject(By.NAME, "RetryButton"); }



    public bool IsDisplayed()
    {
        if (EmailIdInput != null && PasswordInput != null && LoginBtn != null && Google_SignIn_Btn != null && FB_SignIn_Btn != null && ForgotPwd_Btn != null && CreateNow_Btn != null)
        {
            return true;
            LoggingScript.Instance.AddLog("Login page loadedd with all mobile elements:");
        }
            return false;
       
    }
    /*public void ClickLoginHere()
    {
        Thread.Sleep(5000);
        LoginHerebtn.Tap();
    }
    public string GetLoginHereButtonText()
    {
        return LoginHerebtn.GetText();
    }*/

    public void LoginEmail()
    {
        


        EmailIdInput.SetText("david@mailinator.com");
        LoggingScript.Instance.AddLog("Entered email into emai input field");
        
        PasswordInput.SetText("Indus@123");
        LoggingScript.Instance.AddLog("Entered password into password field");
        
        LoginBtn.Tap();
        
        LoggingScript.Instance.AddLog("Clicked on login button");


    }

    public bool ForgotPasswordlink_present_Loginscreen()
    {
        if (ForgotPwd_Btn.enabled)
            return true;
        return false;
    }
    //CreateNow_Btn
    public bool CreateNow_Button()
    {
        if (CreateNow_Btn.enabled)
            return true;
        return false;
    }

    public void PressForgotPwdBtn()
    {
        ForgotPwd_Btn.Tap();
        LoggingScript.Instance.AddLog("Clicked on Forgot paswword button");
    }

    public void PressGoogleSignInBtn()
    {
        Google_SignIn_Btn.Tap();
        LoggingScript.Instance.AddLog("Clicked on Google signin button");
    }
    public void PressFBSignInBtn()
    {
        FB_SignIn_Btn.Tap();
        LoggingScript.Instance.AddLog("Clicked on signin with Facebook button");
    }
    public void PressCreateNowBtn()
    {
        CreateNow_Btn.Tap();
        LoggingScript.Instance.AddLog("Clicked on create account button");
    }
    //RetryButton
    public void PressRetryButton()
    {
        RetryButton.Tap();
        LoggingScript.Instance.AddLog("Clicked on Retry button");
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
        return Error_text.GetText();
    }
    public string getPopupText()
    {
        return PopUp_text.GetText();
    }

    public void not_Filling_Data()
    {
       
        LoginBtn.Tap();
        LoggingScript.Instance.AddLog("Clicked on login button with out entering data");


    }
    public void not_Filling_Email()
    {
        //Thread.Sleep(2000);
        EmailIdInput.SetText("");
        LoggingScript.Instance.AddLog("Entered email into emai input field");
        
        PasswordInput.SetText("Indus@123");
        LoggingScript.Instance.AddLog("Entered password into password field");
        
        LoginBtn.Tap();
        
        LoggingScript.Instance.AddLog("Clicked on login button without entering any email");


    }
    public void not_filling_password()
    {
        Thread.Sleep(2000);
        EmailIdInput.SetText("somikroy@mailinator.com");
        LoggingScript.Instance.AddLog("Entered email into emai input field");
       
       // PasswordInput.SetText("");
        LoggingScript.Instance.AddLog("not Entered password into password field");
        
        LoginBtn.Tap();
        
        LoggingScript.Instance.AddLog("Clicked on login button without enter password");


    }
    public void passing_incorrect_Email_validPassword()
    {
        
        EmailIdInput.SetText("somik12@gmail.com");
        LoggingScript.Instance.AddLog("Entered incorrect email into email input field");
        
        PasswordInput.SetText("Indus@123");
        LoggingScript.Instance.AddLog("Entered valid password into password field");
        
        LoginBtn.Tap();
        
        LoggingScript.Instance.AddLog("Clicked on login button");


    }
    public void passing_correctEmail_InvalidPassword()
    {
        
        EmailIdInput.SetText("somikroy@mailinator.com");
        LoggingScript.Instance.AddLog("Entered email into emai input field");
        
        PasswordInput.SetText("@mailinator.com");
        LoggingScript.Instance.AddLog("Entered password into password field");
        
        LoginBtn.Tap();
       
        LoggingScript.Instance.AddLog("Clicked on login button with invalid password");


    }
    

}