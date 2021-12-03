using NUnit.Framework;
using Altom.AltUnityDriver;


namespace Editor.TestUnderDogPoker.Pages
{
    public class HistoryPage : BasePage
    {
        public HistoryPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard", true);

        }
/*        PlayerHandHistoryPanel
HandHistory_Text
HandHistory_Button_Panel
Hand_Button
TABLE_Button
CARDS_Button
WINNER_Button
POT_Button

Button {Send Game Summary via Email
    }

    ErrorMessage_Panel
    OkayButton


HandHistoryBodyPanel
PlayerHandHistoryObj(Clone)*/

        //BackButton
        public AltUnityObject HandHistory_Text { get => Driver.WaitForObject(By.NAME, "HandHistory_Text", timeout: 2); }

        public AltUnityObject Hand_Button { get => Driver.WaitForObject(By.NAME, "Hand_Button", timeout: 2); }
        public AltUnityObject TABLE_Button { get => Driver.WaitForObject(By.NAME, "TABLE_Button", timeout: 2); }
        public AltUnityObject CARDS_Button { get => Driver.WaitForObject(By.NAME, "CARDS_Button", timeout: 2); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }
        public AltUnityObject WINNER_Button { get => Driver.WaitForObject(By.NAME, "WINNER_Button", timeout: 2); }

        public AltUnityObject POT_Button { get => Driver.WaitForObject(By.NAME, "POT_Button", timeout: 2); }
        public AltUnityObject sendemail_Button { get => Driver.WaitForObject(By.NAME, "Button", timeout: 2); }
        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton", timeout: 2); }

        public bool IsDisplayed()
        {
            if (Hand_Button != null && HandHistory_Text != null && TABLE_Button != null && CARDS_Button != null && BackButton != null && WINNER_Button!= null && POT_Button!= null && sendemail_Button!= null)
            {
                LoggingScript.Instance.AddLog("Inventory screen loaded successfully");
                return true;
            }
            return false;


        }

       
        public void PressSendEmailButton()
        {
            sendemail_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on history send email button");

        }
        public void PressOkayButton()
        {
            OkayButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Okay button");

        }



    }
}
