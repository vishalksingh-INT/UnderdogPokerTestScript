using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Editor.TestUnderDogPoker.Pages
{
    public class WelcomeBonusRewardPage : BasePage

    {
        public WelcomeBonusRewardPage(AltUnityDriver driver) : base(driver)
        {
        }
        public void Load()
        {
            Driver.LoadScene("Dashboard",true);
            
        }

        ///Welcome BonusReward_Panel
        //Welcome_Image
        //YouGot_Text

        //2ItemsContainer
        //Item1Img
        //Item2Img
        //Bonus1_Text
        //Bonus2_Text


        //public AltUnityObject Claim_btn { get => Driver.WaitForObject(By.NAME, "ClaimButton"); }
        // string Claim_btn = "ClaimButton";
        //ClaimButton


        public AltUnityObject Welcome_Image { get => Driver.WaitForObject(By.NAME, "Welcome_Image", timeout: 2); }
        public AltUnityObject YouGot_Tex { get => Driver.WaitForObject(By.NAME, "YouGot_Tex"); }
        public AltUnityObject Item1Img { get => Driver.WaitForObject(By.NAME, "Item1Img", timeout: 2); }
        public AltUnityObject Item2Img { get => Driver.WaitForObject(By.NAME, "Item2Img"); }
        public AltUnityObject Claim_btn { get => Driver.WaitForObject(By.NAME, "ClaimButton"); }
        
       

        public bool IsDisplayed()
        {
            if (Welcome_Image != null && YouGot_Tex != null && Item1Img != null && Item2Img != null && Claim_btn != null )
            {
                return true;
            }
            return false;
        }
        public void PressClaimButton()
        {           
            Claim_btn.Tap();
            
        }
    }
    
}