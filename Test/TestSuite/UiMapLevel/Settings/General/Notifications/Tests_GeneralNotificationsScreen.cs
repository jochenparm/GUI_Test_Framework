using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.UiMapLevel.Settings.General.Notifications
{
    [TestFixture, Property("UiMap", "General_Settings_Notifications_UIITems")]
    public class Tests_GeneralNotificationsScreen
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
            MailWasher.Navigator.Settings.General.Notifications.Navigate();
        }

        [Test]
        public void Verify_Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Play_Sound_When_New_Mail_Arrives_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_New_Mail_Arrives_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Dont_Notify_Me_When_Mail_Is_Spam_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Dont_Notify_Me_When_Mail_Is_Spam_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Play_Sound_When_Error_Occurs_CheckBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_Error_Occurs_CheckBox.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Save_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Save_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Display_Duration_Reset_Button_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Duration_Reset_Button.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_Display_Duration_Slider_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Duration_Slider.IsOnScreen.ShouldBeTrue();
        }

        [Test]
        public void Verify_New_Mail_Sound_Path_TextBox_Is_OnScreen_On_Start()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.New_Mail_Sound_Path_TextBox.IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}