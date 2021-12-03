using NUnit.Framework;
using Altom.AltUnityDriver;


namespace Editor.TestUnderDogPoker.Pages
{
    public class WatchadPage : BasePage
    { 
        public WatchadPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard", true);

        }
       /* AdRewards_Panel
        Text
        { You got }
        OkayButton
*/
        //BackButton
        public AltUnityObject Text { get => Driver.WaitForObject(By.NAME, "Text", timeout: 2); }

        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton", timeout: 2); }
       
        public bool IsDisplayed()
        {
            if (Text != null )
            {
                LoggingScript.Instance.AddLog("Watch ad screen loaded successfully");
                return true;
            }
            return false;


        }


       
        public void PressOkayButton()
        {
            OkayButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on Okay button");

        }



    }
}
