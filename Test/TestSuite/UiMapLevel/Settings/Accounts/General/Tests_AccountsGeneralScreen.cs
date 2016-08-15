using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.General
{
    [TestFixture, Property("UiMap", "Accounts_Settings_General_UIITems")]
    public class Tests_AccountsGeneralScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.Accounts.General.Navigate();
        }

        [Test]
        public void Verify_Account_Description_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Account_Description_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Email_Address_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Email_Address_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Include_In_Default_Mail_Check_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Include_In_Default_Mail_Check_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}