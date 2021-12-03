using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class NickNamePage : BasePage

    {
        public NickNamePage(AltUnityDriver driver) : base(driver)
        {
        }
        public void Load()
        {
            Driver.LoadScene("Dashboard");

        }
        // NickName_Panel
        //NickName
        //Text (1) //Don't worry, this can be changed later.
        //OkayButton
        public AltUnityObject NickName { get => Driver.WaitForObject(By.NAME, "NickName"); }
        public AltUnityObject Text { get => Driver.WaitForObject(By.NAME, "Text (1)"); }
        public AltUnityObject OkayButton { get => Driver.WaitForObject(By.NAME, "OkayButton"); }

        const string textMessage = "Don't worry, this can be changed later.";


        public bool IsDisplayed()
        {
            if (NickName != null && Text != null && OkayButton != null )
            {
                return true;
                LoggingScript.Instance.AddLog("Nickname page loadedd with all elements:");
            }
            return false;
        }

        public void SetNickName()
        {
           
            const string text = "Demo1";
            NickName.SetText(text);
            
        }

        public void Set_alphanumericdata_NickName()
        {

            const string text = "Tom007";
            NickName.SetText(text);
           
        }
        public void Setonlyspace_NickName()
        {

            const string text = "  ";
            NickName.SetText(text);
          

        }
        public void Setalreadypresent_NickName()
        {

            const string text = "Srinivas";
            NickName.SetText(text);
            

        }
        
        public void VerifyTextNickName()
        {
            Assert.AreEqual(Text.GetText(), textMessage);
        }

     
        public void PressOkayButtonNickName()
        {
            OkayButton.Tap();
           // Assert.AreEqual("Okay Button", OkayButton.name);
          
        }



    }

}