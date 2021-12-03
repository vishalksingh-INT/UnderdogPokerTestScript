using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class PublicTablePage : BasePage
    {
        public PublicTablePage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Gameplay", true);

        }
        // PublicTable_Button
        //PublicTable_List
        //PokerViaVideoToggle
        //BackButton

        public AltUnityObject PokerViaVideoToggle { get => Driver.WaitForObject(By.NAME, "PokerViaVideoToggle", timeout: 2); }

       public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject Table { get => Driver.WaitForObject(By.NAME, "TABLE", timeout: 2); }
        public AltUnityObject Game { get => Driver.WaitForObject(By.NAME, "GAME", timeout: 2); }
        public AltUnityObject Stakes { get => Driver.WaitForObject(By.NAME, "STAKES", timeout: 2); }
        public AltUnityObject Buyin { get => Driver.WaitForObject(By.NAME, "BUY_IN", timeout: 2); }
        public AltUnityObject Player { get => Driver.WaitForObject(By.NAME, "PLAYER", timeout: 2); }
        public AltUnityObject Join { get => Driver.WaitForObject(By.NAME, "Join", timeout: 2); }
        public AltUnityObject Observe { get => Driver.WaitForObject(By.NAME, "Observe", timeout: 2); }

        public AltUnityObject Tabledata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/TABLE", timeout: 2); }
        public AltUnityObject Gamedata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/GAME", timeout: 2); }
        public AltUnityObject Stakesdata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/STAKES", timeout: 2); }
        public AltUnityObject Mindata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/MIN", timeout: 2); }
        public AltUnityObject Maxdata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/MAX", timeout: 2); }
        public AltUnityObject Playerdata { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/PLAYER", timeout: 2); }

        public AltUnityObject ObserverButton { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/ObserverButton", timeout: 2); }

        public AltUnityObject PokerBoardTable { get => Driver.WaitForObject(By.NAME, "PokerBoardTable", timeout: 2); }
        public AltUnityObject TableIDHolder { get => Driver.WaitForObject(By.NAME, "TableIDHolder", timeout: 2); }
        public AltUnityObject MenuButton { get => Driver.WaitForObject(By.NAME, "MenuButton", timeout: 2); }

        public AltUnityObject Lobbyback { get => Driver.WaitForObject(By.NAME, "LobbyContainer", timeout: 2); }
        public AltUnityObject HandHistory { get => Driver.WaitForObject(By.NAME, "HandHistoryConatiner", timeout: 2); }
        public AltUnityObject Settings { get => Driver.WaitForObject(By.NAME, "SettingsConatiner", timeout: 2); }

        public AltUnityObject OkButton { get => Driver.WaitForObject(By.NAME, "OkButton", timeout: 2); }
        public AltUnityObject CancelButton { get => Driver.WaitForObject(By.NAME, "CancelButton", timeout: 2); }
        public AltUnityObject SupportButton { get => Driver.WaitForObject(By.NAME, "SupportButton", timeout: 2); }

        public void SupportButton_tap()
        {
            SupportButton.Tap();
            LoggingScript.Instance.AddLog("clicked on Support Button");
        }

        public void CancelButton_tap()
        {
            CancelButton.Tap();
            LoggingScript.Instance.AddLog("clicked on Cancel button");
        }

        public void OkButton_tap()
        {
            OkButton.Tap();
            LoggingScript.Instance.AddLog("clicked on OK button");
        }

        public void Lobbyback_tap()
        {
            Lobbyback.Tap();
            LoggingScript.Instance.AddLog("clicked on Leave table");
        }

        public bool IsSettingsDisplayed()
        {
            if (Lobbyback != null && HandHistory != null && Settings != null)
            {
                LoggingScript.Instance.AddLog("All menu are displaying");
                return true;
            }
            return false;
        }

        public bool IsBoardDisplayed()
        {
            if (Table != null && TableIDHolder != null)
            {
                LoggingScript.Instance.AddLog("Gameplay board is displayed");
                return true;
            }
            return false;
        }

        public void MenuButton_tap()
        {
            MenuButton.Tap();
            LoggingScript.Instance.AddLog("clicked on menu Button");
        }

        public void ObserverButton_tap()
        {
            ObserverButton.Tap();
            LoggingScript.Instance.AddLog("clicked on ObserverButton");
        }

        public void PokerViaVideoToggle_tap()
        {
            PokerViaVideoToggle.Tap();
            LoggingScript.Instance.AddLog("Clicked on toggle button");
        }

        public bool IsColumnsDisplayed()
        {
            if (Table != null && Game != null && Stakes != null && Buyin != null && Player != null && Join != null && Observe != null)
            {
                LoggingScript.Instance.AddLog("All Column headers loaded succesfully");
                return true;
            }
            return false;
        }


        public bool IsColumnsdataDisp()
        {
            if (Tabledata != null && Gamedata != null && Stakesdata != null && Mindata != null && Maxdata != null && Playerdata != null)
            {
                LoggingScript.Instance.AddLog("All Column data are loaded succesfully");
                return true;
            }
            return false;
        }



        public bool IsDisplayed()
        {
            if (PokerViaVideoToggle != null && BackButton != null )
            {
                LoggingScript.Instance.AddLog("Public table screen loaded successfully");
                return true;
            }
            return false;


        }
    }

    }