using NUnit.Framework;
using Shouldly;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Tabs.Settings.Sync
{
    [TestFixture, Property("UiMap_Sync_Settings", "Account_Button")]
    public class Tests_SyncSettingsScreen_Account_Button : Button_Verification
    {
        public Tests_SyncSettingsScreen_Account_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Sync.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Sync.Account_Button)
        { }
    }

    [TestFixture, Property("UiMap_Sync_Settings", "Mobile_Button")]
    public class Tests_SyncSettingsScreen_Mobile_Button : Button_Verification
    {
        public Tests_SyncSettingsScreen_Mobile_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Sync.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Sync.Mobile_Button)
        { }
    }
}