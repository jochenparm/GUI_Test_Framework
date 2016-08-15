using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.Updates
{
    [TestFixture, Property("UiMap", "General_Settings_Updates_UIITems")]
    public class Tests_GeneralUpdatesScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.General.Updates.Navigate();
        }

        [Test]
        public void Verify_Automatically_Check_For_Update_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Automatically_Check_For_Update_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Download_Path_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Download_Path_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Update_Frequency_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates.Update_Frequency_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}