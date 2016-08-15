using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.Outgoing
{
    [TestFixture, Property("UiMap", "Accounts_Settings_Outgoing_UIITems")]
    public class Tests_AccountsOutgoingScreen_Basic_Settings
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.Accounts.Outgoing.Navigate();
        }

        [Test]
        public void Verify_SMTP_Server_Address_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Address_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Advanced_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Advanced_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }

    [TestFixture, Property("UiMap", "Accounts_Settings_Outgoing_UIITems")]
    public class Tests_AccountsOutgoingScreen_Advanced_Settings
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.Accounts.Outgoing.Advanced.Navigate();
        }

        [Test]
        public void Verify_Server_Port_Number_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Server_Port_Number_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Username_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Username_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Password_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Password_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_SMTP_Server_Requires_Authentication_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Requires_Authentication_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Restore_Default_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Restore_Default_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Secure_Connection_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Secure_Connection_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Use_The_Following_Login_RadioButton_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_The_Following_Login_RadioButton.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}