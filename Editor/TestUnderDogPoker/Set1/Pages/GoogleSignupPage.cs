using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;

namespace Editor.TestUnderDogPoker.Pages
{
    public class GoogleSignupPage : BasePage
    {
        public GoogleSignupPage(AltUnityDriver driver) : base(driver)
        {
        }
        public void LoadScene()
        {
            Driver.LoadScene("Dashboard", true);
        }

        //Email registratin Email_Registration_Panel/

        //ErrorMessage_Panel
        public AltUnityObject ErrorText { get => Driver.WaitForObject(By.NAME, "ErrorMessage_Panel"); }
        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton"); }



        public bool IsDisplayed()
        {
            Thread.Sleep(2000);
            /* //if ()
             {
                 return true;
                 LoggingScript.Instance.AddLog("google signup screen loaded successfully");
             }*/
            return true;
        }

    }
}
