using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.Incoming
{
    [TestFixture, Property("UiMap", "Accounts_Settings_Incoming_UIITems")]
    public class Tests_AccountsIncomingScreen_Basic_Settings
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.Accounts.Incoming.Navigate();
        }

        [Test]
        public void Verify_Server_Type_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Type_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Server_Address_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Address_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_User_Name_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.User_Name_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Password_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Password_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Remember_Password_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Remember_Password_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Store_Cached_Emails_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Store_Cached_Emails_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Advanced_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Advanced_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }

    [TestFixture, Property("UiMap", "Accounts_Settings_Incoming_UIITems")]
    public class Tests_AccountsIncomingScreen_Advanced_Settings
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.Accounts.Incoming.Advanced.Navigate();
        }

        [Test]
        public void Verify_Server_Port_Number_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Port_Number_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Store_Cached_Emails_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Store_Cached_Emails_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Use_OAUTH_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Use_OAUTH_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Download_Read_Emails_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Download_Read_Emails_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Move_Deleted_Messages_Into_Folder_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Move_Deleted_Messages_Into_Folder_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Destination_Folder_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Destination_Folder_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}