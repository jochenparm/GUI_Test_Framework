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
    public class Test_AccountsGeneralScreen
    {
        [SetUp]
        public void SetUp()
        {
            UiMap.Init();
            UiMap.MainWindow.SettingsTab_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
            UiMap.MainWindow.Tabs.Settings.Accounts.General_Button.Click();
        }

        [Test]
        public void Verify_Account_Description_TextBox_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.General.Account_Description_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Email_Address_TextBox_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.General.Email_Address_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Include_In_Default_Mail_Check_CheckBox_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.General.Include_In_Default_Mail_Check_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            UiMap.MainWindow.Tabs.Settings.Accounts.General.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            UiMap.DeInit();
        }
    }
}