using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Settings.General
{
    [TestFixture, Property("UiMap_General_Settings", "Application_Button")]
    public class Tests_GeneralSettingsScreen_Application_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Application_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings", "Checking_Mail_Button")]
    public class Tests_GeneralSettingsScreen_Checking_Mail_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Checking_Mail_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Checking_Mail_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings", "Notifications_Button")]
    public class Tests_GeneralSettingsScreen_Notifications_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Notifications_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings", "Washing_Mail_Button")]
    public class Tests_GeneralSettingsScreen_Washing_Mail_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Washing_Mail_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings", "Performance_Button")]
    public class Tests_GeneralSettingsScreen_Performance_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Performance_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance_Button)
        { }
    }

    [TestFixture, Property("UiMap_General_Settings", "Updates_Button")]
    public class Tests_GeneralSettingsScreen_Updates_Button : Button_Verification
    {
        public Tests_GeneralSettingsScreen_Updates_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates_Button)
        { }
    }
}