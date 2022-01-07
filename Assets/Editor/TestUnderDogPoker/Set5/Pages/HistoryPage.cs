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

        public AltUnityObject Handtext { get => Driver.WaitForObject(By.NAME, "Hand_Text", timeout: 2); }
        public AltUnityObject Tabletext { get => Driver.WaitForObject(By.NAME, "Table_Text", timeout: 2); }
        public AltUnityObject Cards1 { get => Driver.WaitForObject(By.NAME, "Cards1", timeout: 2); }
        public AltUnityObject Cards2 { get => Driver.WaitForObject(By.NAME, "Cards2", timeout: 2); }
        public AltUnityObject Winnertext { get => Driver.WaitForObject(By.NAME, "Winner_Text", timeout: 2); }
        public AltUnityObject pottext { get => Driver.WaitForObject(By.NAME, "Pot_Text", timeout: 2); }

        public AltUnityObject Detailsclick { get => Driver.WaitForObject(By.NAME, "PlayerHandHistoryObj(Clone)", timeout: 2); }

        public AltUnityObject Tabletype { get => Driver.WaitForObject(By.NAME, "TableType_Text", timeout: 2); }
        public AltUnityObject Tablelimit { get => Driver.WaitForObject(By.NAME, "TableLimit_Text", timeout: 2); }
        public AltUnityObject DealerName { get => Driver.WaitForObject(By.NAME, "DealerName_Text", timeout: 2); }
        public AltUnityObject Bigblind { get => Driver.WaitForObject(By.NAME, "BigBlindName_Text", timeout: 2); }
        public AltUnityObject Smallblind { get => Driver.WaitForObject(By.NAME, "SmallBlindName_Text", timeout: 2); }
        public AltUnityObject Handdetails { get => Driver.WaitForObject(By.NAME, "HandDetails_Text", timeout: 2); }
        public AltUnityObject winnerDetails { get => Driver.WaitForObject(By.NAME, "WinnerDetails_Text", timeout: 2); }
        public AltUnityObject Bacbutton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public void Bacbuttontap()
        {
            Bacbutton.Tap();
            LoggingScript.Instance.AddLog("Clicked on back button in hand details");

        }

        public bool IsHandDetails()
        {
            if (Tabletype != null && Tablelimit != null && DealerName != null && Bigblind != null && Smallblind != null && Handdetails != null && winnerDetails != null && Bacbutton != null)
            {
                LoggingScript.Instance.AddLog("Hand History loaded successfully");
                return true;
            }
            return false;
        }

        public void Detailsclicktap()
        {
            Detailsclick.Tap();
            LoggingScript.Instance.AddLog("Clicked on Hand hystory");

        }

        public void BackButtontap()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on back button");

        }

        public bool IstextDisplayed()
        {
            if (Handtext != null && Tabletext != null && Cards1 != null && Cards2 != null && Winnertext != null && pottext != null)
            {
                LoggingScript.Instance.AddLog("History loaded successfully");
                return true;
            }
            return false;
        }

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
