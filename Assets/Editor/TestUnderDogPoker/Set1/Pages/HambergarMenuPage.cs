using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class HambergarMenuPage : BasePage
    {
        public HambergarMenuPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard");
        }
        //HambergarMenu_Panel
        //Inventory_Button
        //History_Button
        //DailyCredits_Button
        //DailyCasino_Button
        //PokerViaVideo
        // WatchAD_Button
        //Settings_Button


        public AltUnityObject Inventory_Button { get => Driver.WaitForObject(By.NAME, "Inventory_Button", timeout: 2); }

        public AltUnityObject History_Button { get => Driver.WaitForObject(By.NAME, "History_Button", timeout: 2); }
        public AltUnityObject DailyCredits_Button { get => Driver.WaitForObject(By.NAME, "DailyCredits_Button", timeout: 2); }
        public AltUnityObject DailyCasino_Button { get => Driver.WaitForObject(By.NAME, "DailyCasino_Button", timeout: 2); }
        public AltUnityObject WatchAD_Button { get => Driver.WaitForObject(By.NAME, "WatchAD_Button", timeout: 2); }
        public AltUnityObject REWARDS_Text { get => Driver.WaitForObject(By.NAME, "REWARDS_Text", timeout: 2); }
        public AltUnityObject Settings_Button { get => Driver.WaitForObject(By.NAME, "Settings_Button", timeout: 2); }

        

        public bool IsDisplayed()
        {
            if (Inventory_Button != null && History_Button != null && DailyCredits_Button != null && DailyCasino_Button != null && WatchAD_Button != null && REWARDS_Text != null && Settings_Button != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Hamburger menu screen loaded successfully");
            }
            return false;

           
        }
        public void PressSettingsButton()
        {
            Settings_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Settings button");
        }
        public void PressInventoryButton()
        {
            Inventory_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Inventory button");
        }
        public void PressHistoryButton()
        {
            History_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on History button");
        }
        public void PressWatchADButton()
        {
            WatchAD_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on WatchAD button");
        }



    }
}