using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class WelcomeDailyRewardPage : BasePage

    {
        public WelcomeDailyRewardPage(AltUnityDriver driver) : base(driver)
        {
        }
        public void Load()
        {
            Driver.LoadScene("Dashboard");

        }
        //WelcomeDailyReward_Panel
        //YouGot_Text  //DAILY BONUS
        // BackButton

        public AltUnityObject YouGot_Text { get => Driver.WaitForObject(By.NAME, "YouGot_Text"); }
        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton"); }
       
        const string textMessage = "DAILY BONUS";


        public bool IsDisplayed()
        {
            if (YouGot_Text != null && BackButton != null )
            {
                LoggingScript.Instance.AddLog("Loaded Welcome Daily rewards screen");
                return true;
            }
            return false;

            
        }

        public void VerifyTextDailyBonus()
        {
            Assert.AreEqual(YouGot_Text.GetText(), textMessage);
        }

        public void PressDailyBonusBackButton()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Back button on Daily rewards screen");

        }

    }

}