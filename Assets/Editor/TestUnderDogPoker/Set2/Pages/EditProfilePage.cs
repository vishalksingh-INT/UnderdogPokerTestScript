using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{

    public class EditProfilePage : BasePage
    {
        public EditProfilePage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard", true);

        }
    
        public AltUnityObject Username { get => Driver.WaitForObject(By.NAME, "Username", timeout: 2); }

        public AltUnityObject Email { get => Driver.WaitForObject(By.NAME, "Email", timeout: 2); }
        public AltUnityObject Country { get => Driver.WaitForObject(By.NAME, "Country", timeout: 2); }
        public AltUnityObject Nickname { get => Driver.WaitForObject(By.NAME, "Nickname", timeout: 2); }
       public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }
        public AltUnityObject MobileNo { get => Driver.WaitForObject(By.NAME, "MobileNo", timeout: 2); }
        public AltUnityObject Zip_code { get => Driver.WaitForObject(By.NAME, "Zip code", timeout: 2); }

        public AltUnityObject Save_Btn { get => Driver.WaitForObject(By.NAME, "Save_Btn", timeout: 2); }
        public AltUnityObject Text { get => Driver.WaitForObject(By.NAME, "Text", timeout: 2); }
        public AltUnityObject ExitGame_Button { get => Driver.WaitForObject(By.NAME, "ExitGame_Button(1)", timeout: 2); }






        public bool IsDisplayed()
        {
            if (Email != null && Country != null && Nickname != null && MobileNo != null && BackButton != null && Zip_code != null && Save_Btn != null)
            {
                LoggingScript.Instance.AddLog("Edit profile screen loaded successfully");
                return true;
            }
            return false;


        }

        public void UpdateNickname()
        {
            Nickname.SetText("Srinivs");
            LoggingScript.Instance.AddLog("Nick name entered");
        }
        public void UpdateMobileNo()
        {
            MobileNo.SetText("8686101046");
            LoggingScript.Instance.AddLog("mobile number entered");

        }

        public void PressSaveButton()
        {
            Save_Btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Save button");

        }

        public void PressOkayButton()
        {
            ExitGame_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on okay button");

        }
    }

}