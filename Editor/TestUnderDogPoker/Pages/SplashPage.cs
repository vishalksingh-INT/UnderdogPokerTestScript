using NUnit.Framework;
using Altom.AltUnityDriver;
using Editor.TestUnderDogPoker.Pages;

public class SplashPage : BasePage
{

    public SplashPage(AltUnityDriver driver) : base(driver)
    {
    }
    public void Load()
    {
        Driver.LoadScene("Start");
    }
   /* public AltUnityDriver AltUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        AltUnityDriver =new AltUnityDriver();
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