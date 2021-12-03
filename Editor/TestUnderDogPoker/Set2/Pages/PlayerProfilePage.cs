using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using System.Threading;
namespace Editor.TestUnderDogPoker.Pages
{

    public class PlayerProfilePage : BasePage
    {
        public PlayerProfilePage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard", true);

        }
       

        public AltUnityObject Avatar { get => Driver.WaitForObject(By.NAME, "Player_Avatat", timeout: 2); }

        public AltUnityObject PlayerName { get => Driver.WaitForObject(By.NAME, "PlayerName", timeout: 2); }
        public AltUnityObject PlayerChips { get => Driver.WaitForObject(By.NAME, "PlayerChips", timeout: 2); }
        public AltUnityObject PlayerGems { get => Driver.WaitForObject(By.NAME, "PlayerGems", timeout: 2); }
       // public AltUnityObject GiftsButton { get => Driver.WaitForObject(By.NAME, "Gifts_Button", timeout: 2); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }
        public AltUnityObject Share_Btn { get => Driver.WaitForObject(By.NAME, "Share_Btn", timeout: 2); }
        public AltUnityObject EditProfile_Btn { get => Driver.WaitForObject(By.NAME, "EditProfile_Btn", timeout: 2); }
        public AltUnityObject PlayerAvatar { get => Driver.WaitForObject(By.NAME, "PlayerAvatar", timeout: 20); }
        public AltUnityObject PlayerName_Text { get => Driver.WaitForObject(By.NAME, "PlayerName_Text", timeout: 2); }
        public AltUnityObject PlayerChips_Text { get => Driver.WaitForObject(By.NAME, "PlayerChips_Text", timeout: 2); }
        public AltUnityObject PlayerGems_Text { get => Driver.WaitForObject(By.NAME, "PlayerGems_Text", timeout: 2); }
        public AltUnityObject Back_Button { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }

        public AltUnityObject HandsPlayed { get => Driver.WaitForObject(By.NAME, "HandsPlayed_Label", timeout: 2); }
        public AltUnityObject BiggestWon { get => Driver.WaitForObject(By.NAME, "BiggestWon_Label", timeout: 2); }
        public AltUnityObject BestWinHand { get => Driver.WaitForObject(By.NAME, "BestWinHand_Label", timeout: 2); }
        public AltUnityObject PreFlopFold { get => Driver.WaitForObject(By.NAME, "PreFlop", timeout: 2); }
        public AltUnityObject TurnFold { get => Driver.WaitForObject(By.NAME, "Turn_Label", timeout: 2); }
        public AltUnityObject FlopFold { get => Driver.WaitForObject(By.NAME, "Flop_Label", timeout: 2); }
        public AltUnityObject RiverFold { get => Driver.WaitForObject(By.NAME, "River_Label", timeout: 2); }
        public AltUnityObject RaiseFrequency { get => Driver.WaitForObject(By.NAME, "RaiseFrequency_Label", timeout: 2); }
        public AltUnityObject StakeTable { get => Driver.WaitForObject(By.NAME, "StakeTable_Label", timeout: 2); }
        public AltUnityObject MostStake { get => Driver.WaitForObject(By.NAME, "MostStake_Label", timeout: 2); }

        public AltUnityObject Username { get => Driver.WaitForObject(By.NAME, "Username", timeout: 2); }
        public AltUnityObject Email { get => Driver.WaitForObject(By.NAME, "Email", timeout: 2); }
        public AltUnityObject VerifyEmail { get => Driver.WaitForObject(By.NAME, "VerifyEmail_Button", timeout: 2); }
        public AltUnityObject Country { get => Driver.WaitForObject(By.NAME, "Country", timeout: 2); }
        public AltUnityObject Nickname { get => Driver.WaitForObject(By.NAME, "Nickname", timeout: 2); }
        public AltUnityObject MobileNo { get => Driver.WaitForObject(By.NAME, "MobileNo", timeout: 2); }
        public AltUnityObject Zipcode { get => Driver.WaitForObject(By.NAME, "Zip code", timeout: 2); }
        public AltUnityObject ExitOkButton { get => Driver.WaitForObject(By.NAME, "ExitGame_Button(1)", timeout: 2); }
        public AltUnityObject SaveBtn { get => Driver.WaitForObject(By.NAME, "Save_Btn", timeout: 2); }

        public AltUnityObject BackButton_avatar { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }
        public AltUnityObject PName { get => Driver.WaitForObject(By.NAME, "PlayerName(1)", timeout: 2); }
        public AltUnityObject SelectBtnn { get => Driver.WaitForObject(By.NAME, "Select_Btn", timeout: 2); }
        public AltUnityObject AvatearInside { get => Driver.WaitForObject(By.NAME, "Avatear_2", timeout: 2); }

        public AltUnityObject ProfileBttn { get => Driver.WaitForObject(By.NAME, "ProfileBtn", timeout: 2); }

        public AltUnityObject AvatarGoinside { get => Driver.WaitForObject(By.NAME, "Avatar", timeout: 2); }
        public AltUnityObject AvatarIconbg { get => Driver.WaitForObject(By.NAME, "Avatar_BG", timeout: 2); }



        public bool IsSelectAvatarScreen()
        {
            if (BackButton_avatar != null && SelectBtnn != null)
            {
                LoggingScript.Instance.AddLog("Inside select avatar screen");
                return true;
            }
            return false;
        }

        public void Avatarsave_tap()
        {
            SelectBtnn.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }

        public void AvatearInside_tap()
        {
            AvatearInside.Tap();
            LoggingScript.Instance.AddLog("selected new avatar");
        }

        public void backbuttonavatar_tap()
        {
            BackButton_avatar.Tap();
            LoggingScript.Instance.AddLog("clicked on back button");

        }
        public bool IsAvatarDisplayed()
        {
            if (PlayerAvatar != null)
            {
                LoggingScript.Instance.AddLog("Avatar is loaded");
                return true;
            }
            return false;
        }

        public void EmailId_fill()
        {
            Email.SetText("");
            LoggingScript.Instance.AddLog("Entered empty in email field");
            VerifyEmail.Tap();
            LoggingScript.Instance.AddLog("Clicked on Verify email");
        }

        public void NoEmailId_fill()
        {
            Email.SetText("");
            LoggingScript.Instance.AddLog("Entered empty in email field");
            SaveBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Save button");
        }

        public void NoNickname_fill()
        {
            Nickname.SetText("");
            LoggingScript.Instance.AddLog("Entered empty in Nickname field");
            SaveBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }

        public void NoMobileNo_fill()
        {
            MobileNo.SetText("");
            LoggingScript.Instance.AddLog("Entered empty in MobileNo field");
            SaveBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }

        public void NoZipcode_fill()
        {
            Zipcode.SetText("");
            LoggingScript.Instance.AddLog("Entered empty in Zipcode field");
            SaveBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }


        public void AllFill_fill()
        {
            Email.SetText("david@mailinator.com");
            Nickname.SetText("somikroys");
            MobileNo.SetText("8677767563");
            Zipcode.SetText("576234");
            LoggingScript.Instance.AddLog("Entered values in all the field");
            SaveBtn.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }

        public void AllFillok_fill()
        {
            Email.SetText("somikroy@gmail.com");
            Nickname.SetText("somikroys");
            MobileNo.SetText("8677767563");
            Zipcode.SetText("576234");
            LoggingScript.Instance.AddLog("Entered values in all the field");
            Thread.Sleep(8000);
            SaveBtn.Tap();
            Thread.Sleep(10000);
            LoggingScript.Instance.AddLog("success message recieved");
            ExitOkButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on save button");
        }

        public bool IsEditDisplayed()
        {
            if (Username != null && Email != null && VerifyEmail != null && Country != null && Nickname != null && MobileNo != null && Zipcode != null && SaveBtn != null)
            {
                return true;
            }
            return false;
        }

        public void EditButton_tap()
        {
            EditProfile_Btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Edit button");
        }

        public void BackButton_tap()
        {
            Back_Button.Tap();
            LoggingScript.Instance.AddLog("Clicked on Back button of welcome bonus page");
        }

        public bool IsDisplayed()
        {
            if (Avatar != null && PlayerName != null && PlayerChips != null && PlayerGems != null && BackButton != null && Share_Btn != null && EditProfile_Btn != null)
            {
                LoggingScript.Instance.AddLog("player profile screen loaded successfully");
                return true;
            }
            return false;


        }

        public void Avataricon_tap()
        {
            AvatarGoinside.Tap();
            LoggingScript.Instance.AddLog("Clicked on Avatar");
        }

        public bool IsStatsDisplayed()
        {
            if (HandsPlayed != null && BiggestWon != null && BestWinHand != null && PreFlopFold != null && TurnFold != null && FlopFold != null && RiverFold != null && RaiseFrequency != null && StakeTable != null && MostStake != null)
            {
                LoggingScript.Instance.AddLog("player Stats screen loaded successfully");
                return true;
            }
            return false;
        }

        public void Avatar_tap()
        {
            ProfileBttn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Avatar");
        }

        public void ShareButton_tap()
        {
            Share_Btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on Share button");
        }

        public void PressEditProfileButton()
        {
            EditProfile_Btn.Tap();
            LoggingScript.Instance.AddLog("Clicked on edit profile button");


        }
    
        
    }
}