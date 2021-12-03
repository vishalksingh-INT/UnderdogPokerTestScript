using NUnit.Framework;
using Altom.AltUnityDriver;

namespace Editor.TestUnderDogPoker.Pages
{
    public class NotificationPage : BasePage
    {
        public NotificationPage(AltUnityDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Dashboard");
        }

        public AltUnityObject Header { get => Driver.WaitForObject(By.NAME, "Header", timeout: 2); }

        const string headerText = "NOTIFICATION";

        public AltUnityObject BackButton { get => Driver.WaitForObject(By.NAME, "BackButton", timeout: 2); }
        public AltUnityObject LabelHeader { get => Driver.WaitForObject(By.NAME, "LabelHeader", timeout: 2); }
        public AltUnityObject MessageTab { get => Driver.WaitForObject(By.NAME, "Message", timeout: 2); }
        public AltUnityObject NewsTab { get => Driver.WaitForObject(By.NAME, "News", timeout: 2); }
        public AltUnityObject SUPPORTTab { get => Driver.WaitForObject(By.NAME, "SUPPORT", timeout: 2); }
        public AltUnityObject MessagesTab { get => Driver.WaitForObject(By.NAME, "Message", timeout: 2); }
        public AltUnityObject NewsTabs { get => Driver.WaitForObject(By.NAME, "News", timeout: 2); }
        public AltUnityObject SupportTab { get => Driver.WaitForObject(By.NAME, "SUPPORT", timeout: 2); }
        public AltUnityObject NewsTabCheck { get => Driver.WaitForObject(By.NAME, "NotificationItem_News(Clone)", timeout: 2); }
        public AltUnityObject SupportTabCheck { get => Driver.WaitForObject(By.NAME, "NotificationItem_Support(Clone)", timeout: 2); }



        public bool IsDisplayed()
        {
            if (BackButton != null && LabelHeader != null && MessageTab != null && NewsTab != null && SUPPORTTab != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Notification screen loaded successfully");
            }
                return false;

            
        }

        public bool IsAllTabDisplayed()
        {
            if (MessageTab != null && NewsTab != null && SupportTab != null)
            {
                return true;
                LoggingScript.Instance.AddLog("All tabs in Notification screen are appearing");
            }
            return false;
        }

        public void MessageTabClick()
        {
            MessagesTab.Tap();

            LoggingScript.Instance.AddLog("Clicked on Message Tab button");
        }

        public void SupportTabClick()
        {
            SupportTab.Tap();

            LoggingScript.Instance.AddLog("Clicked on Support Tab button");
        }

        public void NewsTabClick()
        {
            NewsTabs.Tap();

            LoggingScript.Instance.AddLog("Clicked on News Tab button");
        }

        public bool IsNewsTabDisplayed()
        {
            if (NewsTabCheck != null)
            {
                return true;
                LoggingScript.Instance.AddLog("News Tab is opened and verified");
            }
            return false;
        }

        public bool IsSupportTabDisplayed()
        {
            if (SupportTabCheck != null)
            {
                return true;
                LoggingScript.Instance.AddLog("Support Tab is Displayed");
                LoggingScript.Instance.AddLog("Notifications are appearing in Support Tab");
            }
            return false;
        }

        public void PressBackButton()
        {
            BackButton.Tap();
            LoggingScript.Instance.AddLog("Clicked on back button on notifications screen");
        }
    }
    

    }

