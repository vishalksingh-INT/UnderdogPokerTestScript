using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard");
        }


        public AltUnityObject RewardButton { get => Driver.WaitForObject(By.NAME, "Freereward_Button", timeout: 2); }

         public AltUnityObject ShopButton { get => Driver.WaitForObject(By.NAME, "Shop_Button", timeout: 2); }
        public AltUnityObject Notification_Button { get => Driver.WaitForObject(By.NAME, "Notification_Button", timeout: 2); }
        public AltUnityObject SHOP_Text { get => Driver.WaitForObject(By.NAME, "SHOP_Text", timeout: 2); }
        public AltUnityObject NOTIFICATIONS_Text { get => Driver.WaitForObject(By.NAME, "NOTIFICATIONS_Text", timeout: 2); }
        public AltUnityObject REWARDS_Text { get => Driver.WaitForObject(By.NAME, "REWARDS_Text", timeout: 2); }
        public AltUnityObject Hamburder_Button { get => Driver.WaitForObject(By.NAME, "Hamburder_Button", timeout: 2); }
       
        //Player_Panel
        public AltUnityObject PlayerAvatar { get => Driver.WaitForObject(By.NAME, "PlayerAvatar", timeout: 2); }
        public AltUnityObject PlayerName_Text { get => Driver.WaitForObject(By.NAME, "PlayerName_Text", timeout: 2); }
        public AltUnityObject PlayerChips_Text { get => Driver.WaitForObject(By.NAME, "PlayerChips_Text", timeout: 2); }
        public AltUnityObject PlayerGems_Text { get => Driver.WaitForObject(By.NAME, "PlayerGems_Text", timeout: 2); }
        public AltUnityObject ProfileBtn { get => Driver.WaitForObject(By.NAME, "ProfileBtn", timeout: 2); }

        //Mid_Panel
        
        public AltUnityObject Mid_Panel { get => Driver.WaitForObject(By.NAME, "Mid_Panel", timeout: 2); }
        public AltUnityObject Mid_Button_Panel_PublicTable { get => Driver.WaitForObject(By.NAME, "Mid_Button_Panel_PublicTable", timeout: 2); }
        public AltUnityObject PrivateTable_Button { get => Driver.WaitForObject(By.NAME, "PrivateTable_Button", timeout: 2); }
        public AltUnityObject PrivateClub_Button { get => Driver.WaitForObject(By.NAME, "PrivateClub_Button", timeout: 2); }
       
        // FrindLikeShare_Panel
        
        public AltUnityObject Friends_Button { get => Driver.WaitForObject(By.NAME, "Friends_Button", timeout: 2); }
        public AltUnityObject Like_Button { get => Driver.WaitForObject(By.NAME, "Like_Button", timeout: 2); }
        public AltUnityObject Share_Button { get => Driver.WaitForObject(By.NAME, "Share_Button", timeout: 2); }


        // PublicTable_Button
        public AltUnityObject PublicTable_Button { get => Driver.WaitForObject(By.NAME, "PublicTable_Button", timeout: 2); }
        public bool IsDisplayed()
        {
            if (RewardButton != null && ShopButton != null && Notification_Button != null && Hamburder_Button != null && PlayerAvatar != null && PlayerName_Text != null && PlayerChips_Text != null && PlayerGems_Text != null && ProfileBtn != null
                && Mid_Panel != null && Mid_Button_Panel_PublicTable != null && PrivateTable_Button != null && PrivateClub_Button != null && Friends_Button != null && Like_Button != null && Share_Button != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Dashboard screen loaded suceessfully");
            }
                return false;

            
        }

        public void PressHambergarMenu()
        {
            Hamburder_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Hamburger menu button");
        }

        public void PressNotificationButton()
        {
            Notification_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Notifictions button");
        }
        public void PressShopButton()
        {
            ShopButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Shop button");
        }

        public void PressRewardButton()
        {
            RewardButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Rewards button");
        }

        public void PressPlayerAvatarButton()
        {
            PlayerAvatar.Tap();
            LoggingScript.Instance.AddLog("Clicked on Player icon ");
        }

        public void PressPublicTableButton()
        {
            PublicTable_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Public table icon ");
        }

        public void PressPrivateTableButton()
        {
            PrivateTable_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Private table icon ");
        }

        //HambergarMenu_Panel
        //Inventory_Button
        //History_Button
        //DailyCredits_Button
        //DailyCasino_Button
        //PokerViaVideo
        // WatchAD_Button
        //Settings_Button


        //NotificationPanel
        //Header {{ NOTIFICATION}}
        //BackButton
        //LabelHeader
        //Message
        //News
        //SUPPORT
        //




        public AltUnityObject UnityUrlButton { get => Driver.WaitForObject(By.NAME, "UnityURLButton", timeout: 2); }
      
    }  

}