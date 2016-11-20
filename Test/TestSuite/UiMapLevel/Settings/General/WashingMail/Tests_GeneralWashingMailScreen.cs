using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.WashingMail
{
    [TestFixture, Property("UiMap", "General_Settings_Washing_Mail_UIITems")]
    public class Tests_GeneralWashingMailScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Tabs.Settings.General.Washing_Mail.Navigate();
        }

        [Test]
        public void Verify_Minimize_MailWasher_After_Wash_Mail_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Minimize_MailWasher_After_Wash_Mail_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Launch_Email_Program_After_Wash_Mail_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Launch_Email_Program_After_Wash_Mail_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Use_Default_Email_Program_Icon_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Use_Default_Email_Program_Icon_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Email_Program_DropDownMenu_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Email_Program_DropDownMenu.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Email_Program_Path_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Email_Program_Path_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}