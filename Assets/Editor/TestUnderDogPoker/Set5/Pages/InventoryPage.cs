using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard", true);

        }
        //Inventory_Button

//InventoryPanel
//INVENTORY_Text
//Inventory_Button_Panel
//Gifts_Button
//Gems_Button
//Insults_Button
//BackButton
        public AltUnityObject INVENTORY_Text { get => Driver.WaitForObject(By.NAME, "INVENTORY_Text", timeout: 2); }

        public AltUnityObject Gifts_Button { get => Driver.WaitForObject(By.NAME, "Gifts_Button", timeout: 2); }
        public AltUnityObject Gems_Button { get => Driver.WaitForObject(By.NAME, "Gems_Button", timeout: 2); }
        public AltUnityObject Insults_Button { get => Driver.WaitForObject(By.NAME, "Insults_Button", timeout: 2); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject Inventoryimg { get => Driver.WaitForObject(By.NAME, "Inventory_Image", timeout: 2); }
        public AltUnityObject giftname { get => Driver.WaitForObject(By.NAME, "Name_Text", timeout: 2); }
        public AltUnityObject Bgimage { get => Driver.WaitForObject(By.NAME, "BG_Img", timeout: 2); }

        public AltUnityObject Itemlabel { get => Driver.WaitForObject(By.NAME, "Item_Label", timeout: 2); }
        public AltUnityObject Userlevel { get => Driver.WaitForObject(By.NAME, "User_Level", timeout: 2); }
        public AltUnityObject UserAvatar { get => Driver.WaitForObject(By.NAME, "User_Avater", timeout: 2); }
        public AltUnityObject Usernametext { get => Driver.WaitForObject(By.NAME, "UserName_Text", timeout: 2); }
        public AltUnityObject plusbutton { get => Driver.WaitForObject(By.NAME, "Plus_Button", timeout: 2); }
        public AltUnityObject minusbutton { get => Driver.WaitForObject(By.NAME, "Minus_Button", timeout: 2); }
        public AltUnityObject friendbutton { get => Driver.WaitForObject(By.NAME, "Friends_Button", timeout: 2); }

        public AltUnityObject Content { get => Driver.WaitForObject(By.NAME, "Content", timeout: 2); }

        public bool IscontengemsDisplayed()
        {
            if (Content != null)
            {
                LoggingScript.Instance.AddLog("gems content loaded");
                return true;
            }
            return false;
        }

        public void friendbuttontap()
        {
            friendbutton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Send Button");

        }

        public void plusbuttontap()
        {
            plusbutton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Plues Button");

        }

        public void minusbuttontap()
        {
            minusbutton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Minus button");

        }

        public bool IsfriendpanelDisplayed()
        {
            if (Itemlabel != null && Userlevel != null && UserAvatar != null && Usernametext != null && plusbutton != null && minusbutton != null && friendbutton != null)
            {
                LoggingScript.Instance.AddLog("Friend panel displayed and all the UI is loaded");
                return true;
            }
            return false;
        }

        public bool IsgiftDisplayed()
        {
            if (Inventoryimg != null && giftname != null && Bgimage != null)
            {
                LoggingScript.Instance.AddLog("GIFTS loaded successfully");
                return true;
            }
            return false;
        }

        public void BackButtontap()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Back button");

        }

        public void Bgimagetp()
        {
            Bgimage.Tap();
            LoggingScript.Instance.AddLog("Clicked on gift item");

        }

        public bool IsDisplayed()
        {
            if (INVENTORY_Text != null && Gifts_Button != null && Gems_Button != null && Insults_Button != null && BackButton != null )
            {
                LoggingScript.Instance.AddLog("Inventory screen loaded successfully");
                return true;
            }
            return false;


        }

        public void PressGiftsButton()
        {
            Gifts_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on gifts button");

        }

        public void PressGemsButton()
        {
            Gems_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on gems button");

        }

        public void PressInsultsButton()
        {
            Insults_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Insults button");

        }


    }
}

