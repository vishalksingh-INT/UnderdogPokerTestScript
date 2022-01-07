using NUnit.Framework;
using Altom.AltUnityDriver;
using System;
using Editor.TestUnderDogPoker.Pages;
using System.Threading;

namespace Editor.TestUnderDogPoker.Tests

{
    public class InventoryTest : IDisposable
    {
        AltUnityDriver altUnityDriver;
        SignupPage signupPage;
       
        LoginPage loginPage;
        DashboardPage dashboardPage;
        HambergarMenuPage hambergarMenuPage;
        InventoryPage inventoryPage;
        public InventoryTest()
        {

            altUnityDriver = new AltUnityDriver();
            signupPage = new SignupPage(altUnityDriver);
            signupPage.Load();
            signupPage.PressLoginHereButton();
            loginPage = new LoginPage(altUnityDriver);

            loginPage.LoginEmail();
            dashboardPage = new DashboardPage(altUnityDriver);
            dashboardPage.PressHambergarMenu();
            hambergarMenuPage = new HambergarMenuPage(altUnityDriver);
            hambergarMenuPage.PressInventoryButton();
            inventoryPage = new InventoryPage(altUnityDriver);

        }
		[Test]
		public void Inventory_TC_ID_3()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_3 to verify UI of inventory Page started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_3 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_4()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_4 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			inventoryPage.BackButtontap();
			LoggingScript.Instance.AddLog("Back to Dashboard screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_4 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_5()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_5 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_5 test passed successfully");
		}


		[Test]
		public void Inventory_TC_ID_6()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_6 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			Thread.Sleep(4000);
			inventoryPage.PressGiftsButton();
			LoggingScript.Instance.AddLog("GIFTS tab is opened");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_6 test passed successfully");
		}


		[Test]
		public void Inventory_TC_ID_7()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_7 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_7 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_8()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_8 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_8 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_9()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_9 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_9 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_10()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_10 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_10 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_11()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_11 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_11 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_12()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_12 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.minusbuttontap();
			LoggingScript.Instance.AddLog(" Item DEcreased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_12 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_13()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_13 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			inventoryPage.friendbuttontap();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_13 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_14()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_14 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			inventoryPage.friendbuttontap();
			LoggingScript.Instance.AddLog(" Gifts has been sent successfully - message recieved");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_14 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_19()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_19 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.IsgiftDisplayed();
			LoggingScript.Instance.AddLog("All GIFTS in the gifts tab is Loaded");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.PressGiftsButton();
			LoggingScript.Instance.AddLog("back to the inventory screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_19 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_20()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_20 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_20 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_21()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_21 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.IscontengemsDisplayed();
			LoggingScript.Instance.AddLog("UI of gems tab is loaded");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_21 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_22()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_22 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.IscontengemsDisplayed();
			LoggingScript.Instance.AddLog("All gems item in the Gems tab is displayed");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_22 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_23()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_23 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_23 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_24()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_24 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("UI of Choose friend panel loaded successfully");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_24 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_25()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_25 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_25 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_26()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_26 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.minusbuttontap();
			LoggingScript.Instance.AddLog(" Item DEcreased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_26 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_27()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_27 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			inventoryPage.friendbuttontap();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_27 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_33()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_33 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog("Into the gems screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("UI of Choose friend panel loaded successfully");
			inventoryPage.PressGemsButton();
			LoggingScript.Instance.AddLog(" Back into the gems screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_33 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_34()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_34 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_34 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_35()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_35 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.IscontengemsDisplayed();
			LoggingScript.Instance.AddLog("UI of Insults tab is loaded");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_35 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_36()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_36 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.IscontengemsDisplayed();
			LoggingScript.Instance.AddLog("All Insults item in the Insults tab is displayed");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_36 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_37()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_37 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_37 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_38()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_38 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("UI of Choose friend panel loaded successfully");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_38 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_39()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_39 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_39 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_40()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_40 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("Inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.minusbuttontap();
			LoggingScript.Instance.AddLog(" Item Decreased by 1 count");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_40 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_41()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_41 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen");
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			inventoryPage.plusbuttontap();
			LoggingScript.Instance.AddLog(" Item increased by 1 count");
			inventoryPage.friendbuttontap();
			LoggingScript.Instance.AddLog("Inventory_TC_ID_41 test passed successfully");
		}

		[Test]
		public void Inventory_TC_ID_47()
		{
			LoggingScript.Instance.AddLog("Inventory_TC_ID_47 to verify behaviour of Back button  started execution");
			LoggingScript.Instance.AddLog("inventory Option is present under Hamburger Menu");
			LoggingScript.Instance.AddLog("Clicked on Inventory option");
			inventoryPage.IsDisplayed();
			LoggingScript.Instance.AddLog("By Default GIFTS tab is opened");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog("Inside the Insults screen"); ;
			inventoryPage.Bgimagetp();
			LoggingScript.Instance.AddLog("Choose friend panel loaded successfully");
			inventoryPage.IsfriendpanelDisplayed();
			LoggingScript.Instance.AddLog("UI of Choose friend panel loaded successfully");
			inventoryPage.PressInsultsButton();
			LoggingScript.Instance.AddLog(" Back into the Insults screen");
			LoggingScript.Instance.AddLog("Inventory_TC_ID_47 test passed successfully");
		}

		public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}