using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General.Notifications
{
    [TestFixture, Property("UiMap_General_Settings_Notifications", "Save_Button")]
    public class Tests_GeneralNotificationsScreen_Save_Button : Button_Verification
    {
        public Tests_GeneralNotificationsScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Display_Duration_Reset_Button")]
    public class Tests_GeneralNotificationsScreen_Display_Duration_Reset_Button : Button_Verification
    {
        public Tests_GeneralNotificationsScreen_Display_Duration_Reset_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Duration_Reset_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Display_Duration_Slider")]
    public class Tests_GeneralNotificationsScreen_Display_Duration_Slider : Slider_Verification
    {
        public Tests_GeneralNotificationsScreen_Display_Duration_Slider()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Duration_Slider, 1, 14)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "New_Mail_Sound_Path_TextBox")]
    public class Tests_GeneralNotificationsScreen_New_Mail_Sound_Path_TextBox : TextBox_Verification
    {
        public Tests_GeneralNotificationsScreen_New_Mail_Sound_Path_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.New_Mail_Sound_Path_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Play_Sound_When_Error_Occurs_CheckBox")]
    public class Tests_GeneralNotificationsScreen_Play_Sound_When_Error_Occurs_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralNotificationsScreen_Play_Sound_When_Error_Occurs_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_Error_Occurs_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Dont_Notify_Me_When_Mail_Is_Spam_CheckBox")]
    public class Tests_GeneralNotificationsScreen_Dont_Notify_Me_When_Mail_Is_Spam_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralNotificationsScreen_Dont_Notify_Me_When_Mail_Is_Spam_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Dont_Notify_Me_When_Mail_Is_Spam_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Play_Sound_When_New_Mail_Arrives_CheckBox")]
    public class Tests_GeneralNotificationsScreen_Play_Sound_When_New_Mail_Arrives_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralNotificationsScreen_Play_Sound_When_New_Mail_Arrives_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Play_Sound_When_New_Mail_Arrives_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings_Notifications", "Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox")]
    public class Tests_GeneralNotificationsScreen_Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox : CheckBox_Verification
    {
        public Tests_GeneralNotificationsScreen_Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Notifications.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications.Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox)
        { }
    }
}