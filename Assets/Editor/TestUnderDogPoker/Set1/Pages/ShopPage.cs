using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Editor.TestUnderDogPoker.Pages
{
    public class ShopPage : BasePage
    {
        public ShopPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard",true);
       
        }
        //ShopPanel
        
        public AltUnityObject ShopText { get => Driver.WaitForObject(By.NAME, "SHOP_Text", timeout: 2); }

        const string headerText = "SHOP";

        public AltUnityObject ChipsButton { get => Driver.WaitForObject(By.NAME, "Chips_Button", timeout: 2); }
        public AltUnityObject GemsButton { get => Driver.WaitForObject(By.NAME, "Gems_Button", timeout: 2); }
        public AltUnityObject InsultsButton { get => Driver.WaitForObject(By.NAME, "Insults_Button", timeout: 2); }
        public AltUnityObject GiftsButton { get => Driver.WaitForObject(By.NAME, "Gifts_Button", timeout: 2); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "ShopPanel/BackButton", timeout: 2); }
        public AltUnityObject GemsPage { get => Driver.WaitForObject(By.NAME, "Item_Image", timeout: 2); }
        public AltUnityObject GiftButton { get => Driver.WaitForObject(By.NAME, "Gifts_Button", timeout: 2); }
        public AltUnityObject GiftPackage { get => Driver.WaitForObject(By.NAME, "BG_Img", timeout: 2); }
        public AltUnityObject PurchaseGift { get => Driver.WaitForObject(By.NAME, "BG", timeout: 2); }
        public AltUnityObject PurchaseOneGifts { get => Driver.WaitForObject(By.NAME, "Shop_GiftsItemObj(Clone)4/BG_Img", timeout: 2); }
        public AltUnityObject GiftSearch { get => Driver.WaitForObject(By.NAME, "Inventory_GiftItemObj(Clone)5/Name_Text", timeout: 2); }
        public AltUnityObject PurchaseOneInsult { get => Driver.WaitForObject(By.NAME, "Shop_InsultsItemObj(Clone)1/BG_Img", timeout: 2); }
        public AltUnityObject InsultTab { get => Driver.WaitForObject(By.NAME, "Insults_Button", timeout: 2); }

        public bool IsDisplayed()
        {
            if (GemsButton != null && InsultsButton != null && GiftsButton != null)
            {
                LoggingScript.Instance.AddLog("Shop scrren loaded successfully");
                return true;
            }
            return false;

           
        }

        public bool IsGemsDisplayed()
        {
            if (GemsPage != null)
            {
                LoggingScript.Instance.AddLog("Gems screen loaded successfully");
                return true;
            }
            return false;
        }

        public void GemsButtonButton()
        {
            GemsButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on game button on shop screen");
        }

        public void GiftButtonButton()
        {
            GiftButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on gift button on shop screen");
        }

        public bool IsGiftDisplayed()
        {
            if (GemsPage != null)
            {
                LoggingScript.Instance.AddLog("gift screen loaded successfully");
                return true;
            }
            return false;
        }

        public void GiftPackageButton()
        {
            GiftPackage.Tap();

            LoggingScript.Instance.AddLog("Clicked on gift Package");
        }

        public void PurchaseGiftscreen()
        {
            PurchaseGift.Tap();

            LoggingScript.Instance.AddLog("Purchased item");
        }

        public void PurchaseOneGift()
        {
            PurchaseOneGifts.Tap();

            LoggingScript.Instance.AddLog("clicked on One Gift Purchased");
        }

        public void BckButton()
        {
            BackButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on back button");
        }

        public string getGiftText()
        {
            return GiftSearch.GetText();

        }

        public void PurchaseInsult()
        {
            PurchaseOneInsult.Tap();

            LoggingScript.Instance.AddLog("Insult purchased");
        }

        public void InsultNotification()
        {
            InsultTab.Tap();

            LoggingScript.Instance.AddLog("Insult purchased");
        }

        public void InsultButton()
        {
            InsultsButton.Tap();

            LoggingScript.Instance.AddLog("Clicked on Insualt Tab on shop screen");
        }



        public void PressBackButton()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on back button in shop screen");

        }
    
    }

}