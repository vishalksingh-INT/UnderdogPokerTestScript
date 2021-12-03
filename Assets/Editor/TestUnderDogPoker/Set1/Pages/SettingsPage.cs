using NUnit.Framework;
using Altom.AltUnityDriver;


namespace Editor.TestUnderDogPoker.Pages
{
    public class SettingsPage : BasePage
    {
        public SettingsPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard");
        }
        //Settings_Panel
        //BackButton
        // Settings_Text {{SETTINGS}}
        //GDPRPolicy_Button
        //PrivacyPolicy_Button
        //LOGOUT_Button
        //FOLLOWUS_Button
        // T&C_Button
        //CCPAPolicy_Button
        //Sound_Button
        //AllowBuddyRequest_Button


        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject SettingsText { get => Driver.WaitForObject(By.NAME, "Settings_Text", timeout: 2); }
        public AltUnityObject GDPRPolicyButton { get => Driver.WaitForObject(By.NAME, "GDPRPolicy_Button", timeout: 2); }
        public AltUnityObject PrivacyPolicyButton { get => Driver.WaitForObject(By.NAME, "PrivacyPolicy_Button", timeout: 2); }
        public AltUnityObject LOGOUTButton { get => Driver.WaitForObject(By.NAME, "LOGOUT_Button", timeout: 2); }
        public AltUnityObject TCButton { get => Driver.WaitForObject(By.NAME, "T&C_Button", timeout: 5); }
        public AltUnityObject CCPAPolicyButton { get => Driver.WaitForObject(By.NAME, "CCPAPolicy_Button", timeout: 2); }
        public AltUnityObject SoundButton { get => Driver.WaitForObject(By.NAME, "Sound_Button", timeout: 2); }
        public AltUnityObject AllowBuddyRequestButton { get => Driver.WaitForObject(By.NAME, "AllowBuddyRequest_Button", timeout: 2); }



        public bool IsDisplayed()
        {
            if (BackButton != null && SettingsText != null && GDPRPolicyButton != null && PrivacyPolicyButton != null && LOGOUTButton != null && CCPAPolicyButton != null && SoundButton != null && AllowBuddyRequestButton != null)
            {
                LoggingScript.Instance.AddLog("Settings screen loaded successfully");
                return true;
            }
            return false;

            
        }
        public void PressBackButton()
        {
            BackButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on Back button on settings screen");
        }

        public void PressLogoutButton()
        {
            LOGOUTButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on Logout button");
        }

        public void PressGDPRPolicyButton()
        {
            GDPRPolicyButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on GDPRPolicy button");
        }
        public void PressPrivacyPolicyButton()
        {
            PrivacyPolicyButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on PrivacyPolicy button");
        }
        public void PressTCButton()
        {
            TCButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on TCButton button");
        }
        public void PressCCPAPolicyButton()
        {
            CCPAPolicyButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on CCPAPolicy button");
        }
        public void PressSoundButton()
        {
            SoundButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on Sound taggle button");
        }
        public void PressAllowBuddyRequestButton()
        {
            AllowBuddyRequestButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on AllowBuddyRequest taggle button");
        }
    }
}