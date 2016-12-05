using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Tabs.Settings
{
    [TestFixture, Property("UiMap_Settings_Tab", "General_Button")]
    public class Tests_SettingsTabScreen_General_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_General_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.General_Button)
        { }
    }

    [TestFixture, Property("UiMap_Settings_Tab", "Accounts_Button")]
    public class Tests_SettingsTabScreen_Accounts_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_Accounts_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts_Button)
        { }
    }

    [TestFixture, Property("UiMap_Settings_Tab", "SpamTools_Button")]
    public class Tests_SettingsTabScreen_SpamTools_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_SpamTools_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.SpamTools_Button)
        { }
    }

    [TestFixture, Property("UiMap_Settings_Tab", "Display_Button")]
    public class Tests_SettingsTabScreen_Display_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_Display_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Display_Button)
        { }
    }

    [TestFixture, Property("UiMap_Settings_Tab", "RecycleBin_Button")]
    public class Tests_SettingsTabScreen_RecycleBin_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_RecycleBin_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin_Button)
        { }
    }

    [TestFixture, Property("UiMap_Settings_Tab", "General_Button")]
    public class Tests_SettingsTabScreen_Sync_Button : Button_Verification
    {
        public Tests_SettingsTabScreen_Sync_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Sync_Button)
        { }
    }
}