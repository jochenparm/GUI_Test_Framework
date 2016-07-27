using NUnit.Framework;
using Shouldly;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts
{
    [TestFixture, Property("UiMap", "Accounts_Settings_UIItems")]
    public class Tests_AccountsSettingsScreen
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.SettingsTab_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
        }

        [Test]
        public void Verify_General_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.General_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Incoming_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Incoming_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Outgoing_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_IMAP_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.IMAP_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Add_Email_Account_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Add_Email_Account_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Remove_Account_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Remove_Account_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Import_Accounts_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Import_Accounts_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Check_Order_Up_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Check_Order_Up_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Check_Order_Down_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.Check_Order_Down_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}