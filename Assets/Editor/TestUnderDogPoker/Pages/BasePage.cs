using NUnit.Framework;
using Altom.AltUnityDriver;
using Altom.AltUnityDriver.Logging;

namespace Editor.TestUnderDogPoker.Pages
{
    public class BasePage
    {

        AltUnityDriver driver;

        public AltUnityDriver Driver { get => driver; set => driver = value; }
        public BasePage(AltUnityDriver driver)
        {
            Driver = driver;
            //AltUnityRunner.print("driver inslized");
           // driver.SetServerLogging(AltUnityLogger.File, AltUnityLogLevel.Debug);
           // driver.SetServerLogging(AltUnityLogger.Unity, AltUnityLogLevel.Info);
            driver.SetServerLogging(AltUnityLogger.Unity, AltUnityLogLevel.Debug);
            DriverLogManager.SetMinLogLevel(AltUnityLogger.File, AltUnityLogLevel.Debug);
            //LoggingScript.Instance.AddLog("Driver was started succesfully ");

        }
        /*public AltUnityDriver AltUnityDriver;
        //Before any test it connects with the socket
        [OneTimeSetUp]
        public void SetUp()
        {
            AltUnityDriver =new AltUnityDriver();
        var driver = new AltUnityDriver (logFlag=true); //starts altunity driver with logging enabled for Debug.Level; this is the default behaviour

Altom.AltUnityDriver.Logging.DriverLogManager.SetMinLogLevel(AltUnityLogger.File, AltUnityLogLevel.Info); 
        }

        //At the end of the test closes the connection with the socket
        [OneTimeTearDown]
        public void TearDown()
        {
            AltUnityDriver.Stop();
        }

        [Test]
        public void Test()
        {
        //Here you can write the test
        }
    */
    }
}