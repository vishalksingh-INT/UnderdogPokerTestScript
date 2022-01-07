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

        public AltUnityObject EmailSupport { get => Driver.WaitForObject(By.NAME, "Email_InputField", timeout: 2); }
        public AltUnityObject Subject { get => Driver.WaitForObject(By.NAME, "Subject_InputField", timeout: 2); }
        public AltUnityObject Decription { get => Driver.WaitForObject(By.NAME, "Description_InputField", timeout: 2); }
        public AltUnityObject SupportSubmit { get => Driver.WaitForObject(By.NAME, "Submit_Button", timeout: 2); }
        public AltUnityObject SupportBack { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject ChatButton { get => Driver.WaitForObject(By.NAME, "ChatButton", timeout: 2); }
        public AltUnityObject ChatInput { get => Driver.WaitForObject(By.NAME, "InputField", timeout: 2); }
        public AltUnityObject ChatSend { get => Driver.WaitForObject(By.NAME, "SendButton", timeout: 2); }

        public AltUnityObject FoldButton { get => Driver.WaitForObject(By.NAME, "FoldButton", timeout: 2); }
        public AltUnityObject CheckButton { get => Driver.WaitForObject(By.NAME, "CheckButton", timeout: 2); }
        public AltUnityObject RaiseBetlButton { get => Driver.WaitForObject(By.NAME, "RaiseBetlButton", timeout: 2); }
       
        public AltUnityObject JoinButton { get => Driver.WaitForObject(By.NAME, "TableItemView(Clone)/JoinButton", timeout: 2); }
        public AltUnityObject AllInButton { get => Driver.WaitForObject(By.NAME, "AllInButton", timeout: 2); }
        public AltUnityObject Chairadd { get => Driver.WaitForObject(By.NAME, "Chair_1", timeout: 2); }

        public AltUnityObject AmountHolder { get => Driver.WaitForObject(By.NAME, "AmountHolder", timeout: 2); }
        public AltUnityObject Playnowbtn { get => Driver.WaitForObject(By.NAME, "PlayNow_Button", timeout: 2); }

        public AltUnityObject playerchips { get => Driver.WaitForObject(By.NAME, "PLAYERCHIPS", timeout: 2); }
        public AltUnityObject minusbtn { get => Driver.WaitForObject(By.NAME, "Minus_Button", timeout: 2); }
        public AltUnityObject plusbtn { get => Driver.WaitForObject(By.NAME, "Plus_Button", timeout: 2); }
        public AltUnityObject buyinvalue { get => Driver.WaitForObject(By.NAME, "BuyInValue", timeout: 2); }
        public AltUnityObject stakesvalue { get => Driver.WaitForObject(By.NAME, "Stakes_Value", timeout: 2); }
        public AltUnityObject minmaxbuyinval { get => Driver.WaitForObject(By.NAME, "MinMax_Buy-In_Value", timeout: 2); }
        public AltUnityObject maxbuyinbox { get => Driver.WaitForObject(By.NAME, "MaxBuy-IN_Checkbox", timeout: 2); }
        public AltUnityObject autorebuybox { get => Driver.WaitForObject(By.NAME, "AutoRe-Buy_Checkbox", timeout: 2); }
        public AltUnityObject backbtnholdem { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject RuleButton { get => Driver.WaitForObject(By.NAME, "RuleButton", timeout: 2); }

        public AltUnityObject TableNameText { get => Driver.WaitForObject(By.NAME, "TableNameText", timeout: 2); }
        public AltUnityObject GameTypeText { get => Driver.WaitForObject(By.NAME, "GameTypeText", timeout: 2); }
        public AltUnityObject GameLimitText { get => Driver.WaitForObject(By.NAME, "GameLimitText", timeout: 2); }
        public AltUnityObject SpeedText { get => Driver.WaitForObject(By.NAME, "SpeedText", timeout: 2); }
        public AltUnityObject AnteText { get => Driver.WaitForObject(By.NAME, "AnteText", timeout: 2); }
        public AltUnityObject AnteAmountText { get => Driver.WaitForObject(By.NAME, "AnteAmountText", timeout: 2); }
        public AltUnityObject RakeText { get => Driver.WaitForObject(By.NAME, "RakeText", timeout: 2); }
        public AltUnityObject RakePercentageText { get => Driver.WaitForObject(By.NAME, "RakePercentageText", timeout: 2); }
        public AltUnityObject StakesText { get => Driver.WaitForObject(By.NAME, "StakesText", timeout: 2); }
        public AltUnityObject MinBuyInText { get => Driver.WaitForObject(By.NAME, "MinBuyInText", timeout: 2); }
        public AltUnityObject MaxBuyInText { get => Driver.WaitForObject(By.NAME, "MaxBuyInText", timeout: 2); }
        public AltUnityObject DisconnectionText { get => Driver.WaitForObject(By.NAME, "DisconnectionText ", timeout: 2); }


        public bool IsRuleTableDisplayed()
        {
            if (TableNameText != null && GameTypeText != null && GameLimitText != null && SpeedText != null && AnteText != null && AnteAmountText != null && RakeText != null && RakePercentageText != null && StakesText != null && MinBuyInText != null && MaxBuyInText != null && DisconnectionText != null)
			{
                LoggingScript.Instance.AddLog("All rules are displayed displayed");
                return true;
            }
            return false;
        }

        public void RuleButton_tap()
        {
            RuleButton.Tap();
            LoggingScript.Instance.AddLog("clicked on Rule Button");
        }

        public void plusMinus_tap()
        {
            plusbtn.Tap();
            LoggingScript.Instance.AddLog("clicke on + button");
            minusbtn.Tap();
            LoggingScript.Instance.AddLog("clicked on - button");
        }

        public void backbtnholdem_tap()
        {
            backbtnholdem.Tap();
            LoggingScript.Instance.AddLog("clicked on back button");
        }

        public void autobuyin_tap()
        {
            autorebuybox.Tap();
            LoggingScript.Instance.AddLog("clicked on autobuy in option");
        }

        public void maxbuyinbox_tap()
        {
            maxbuyinbox.Tap();
            LoggingScript.Instance.AddLog("clicked on max buy in option");
        }

        public bool IsholdemDisplayed()
        {
            if (backbtnholdem != null && autorebuybox != null && maxbuyinbox != null && minmaxbuyinval != null && stakesvalue != null && buyinvalue != null && plusbtn != null && minusbtn != null && playerchips != null)
            {
                LoggingScript.Instance.AddLog("Holdem screen is displayed");
                return true;
            }
            return false;
        }


        public bool IsPotAmountDisplayed()
        {
            if (AmountHolder != null)
            {
                LoggingScript.Instance.AddLog("Pot amount is displayed - value is 0");
                return true;
            }
            return false;
        }

        public void playnow_tap()
        {
            Playnowbtn.Tap();
            LoggingScript.Instance.AddLog("clicked on play now button");
        }

        public void Chairjoin_tap()
        {
            Chairadd.Tap();
            LoggingScript.Instance.AddLog("clicked on + to join the table as a player");
        }

        public void JoinButton_tap()
        {
            JoinButton.Tap();
            LoggingScript.Instance.AddLog("clicked on join button");
        }

        public bool IsUserUIDisplayed()
        {
            if (FoldButton != null && CheckButton != null && RaiseBetlButton != null && AllInButton != null)
            {
                LoggingScript.Instance.AddLog("UI buttons are loaded and displayed");
                return true;
            }
            return false;
        }

        public void chatsend_tap()
        {
            ChatInput.SetText("chat message");
            ChatSend.Tap();
            LoggingScript.Instance.AddLog("clicked on send button");
        }

        public void chatButton_tap()
        {
            ChatButton.Tap();
            LoggingScript.Instance.AddLog("clicked on chat button");
        }


        public bool IsSupportUIDisplayed()
        {
            if (EmailSupport != null && Subject != null && Decription != null && SupportSubmit != null && SupportBack != null)
            {
                LoggingScript.Instance.AddLog("Support UI is loaded");
                return true;
            }
            return false;
        }

        public void SupportSubmitButton_tap()
        {
            SupportSubmit.Tap();
            LoggingScript.Instance.AddLog("clicked on Submit button");
        }

        public void SupportBack_tap()
        {
            SupportBack.Tap();
            LoggingScript.Instance.AddLog("clicked on back button in the support screen");
        }

        public void Subjectfill()
        {
            Subject.SetText("Need Support");
            LoggingScript.Instance.AddLog("Entered text in subject field");
        }

        public void Decriptionfill()
        {
            Decription.SetText("Need Support");
            LoggingScript.Instance.AddLog("Entered text in description field");
        }

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
            if (PokerBoardTable != null && TableIDHolder != null)
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