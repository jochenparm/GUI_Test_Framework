using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.Application
{
    [TestFixture, Property("UiMap", "General_Settings_Application_UIITems")]
    public class Tests_GeneralApplicationScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.General.Application.Navigate();
        }

        [Test]
        public void Verify_Font_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Font_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Startup_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Startup_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Language_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Language_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Minimize_MailWasher_When_X_Clicked_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_X_Clicked_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Minimize_MailWasher_When_Mail_Program_Launched_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_MailWasher_When_Mail_Program_Launched_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Start_MailWasher_Minimized_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Start_MailWasher_Minimized_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Minimize_To_System_Tray_RadioButton_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_System_Tray_RadioButton.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Minimize_To_Task_Bar_RadioButton_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Minimize_To_Task_Bar_RadioButton.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Reset_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Reset_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Restore_MailWasher_Hotkey_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application.Restore_MailWasher_Hotkey_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}