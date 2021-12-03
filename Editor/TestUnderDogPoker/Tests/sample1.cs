using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using Altom.AltUnityDriver.Logging;

public class sample1
{
    public AltUnityDriver altUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altUnityDriver = new AltUnityDriver();
      //  altUnityDriver.SetServerLogging(AltUnityLogger.File, AltUnityLogLevel.Off);
        altUnityDriver.SetServerLogging(AltUnityLogger.Unity, AltUnityLogLevel.Info);
        // var driver = new AltUnityDriver(logFlag = false); //starts altunity driver with logging disabled

        //  var driver = new AltUnityDriver(logFlag = true); //starts altunity driver with logging enabled for Debug.Level; this is the default behaviour
        Altom.AltUnityDriver.Logging.DriverLogManager.SetMinLogLevel(AltUnityLogger.File, AltUnityLogLevel.Info);

        //AltUnityRunner.print("Driver intialized");
        
        }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
       // AltUnityRunner.print("Driver closing");
        altUnityDriver.Stop();
    }

    [SetUp]
    public void LoadLevel()
    {
        // AltUnityRunner.print("dashboard loading ");

        LoggingScript.Instance.AddLog("Loading Dashboard");
        altUnityDriver.LoadScene("Dashboard", true);
        LoggingScript.Instance.AddLog("Dashboard loaded successfully");


    }

    [Test]
    public void Test()
    {
       // AltUnityDriver.LoadScene("",true);

        Thread.Sleep(2000);

        // string name = AltUnityDriver.FindObject(By.NAME, "WelcomeTextImg").GetText();

        // Assert.Equals(name, "WELCOME TO UNDERDOG POOKER");

        AltUnityRunner.print("Test started ");
        altUnityDriver.FindObject(By.NAME, "Email_SignUp_Btn").Tap();

        AltUnityRunner.print("email button clicked");

        Thread.Sleep(2000);
    }

}