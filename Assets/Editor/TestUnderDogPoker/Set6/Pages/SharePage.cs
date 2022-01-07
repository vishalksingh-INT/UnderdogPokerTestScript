using NUnit.Framework;
using Altom.AltUnityDriver;


namespace Editor.TestUnderDogPoker.Pages
{
    public class SharePage : BasePage
    {
        public SharePage(AltUnityDriver driver) : base(driver)
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





    }
}
