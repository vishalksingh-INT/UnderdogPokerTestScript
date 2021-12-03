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

