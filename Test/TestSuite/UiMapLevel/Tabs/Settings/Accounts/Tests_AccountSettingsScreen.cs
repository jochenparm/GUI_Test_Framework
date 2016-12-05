using NUnit.Framework;
using Shouldly;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts
{
    [TestFixture, Property("UiMap_Accounts_Settings", "General_Button")]
    public class Tests_AccountsSettingsScreen_General_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_General_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Incoming_Button")]
    public class Tests_AccountsSettingsScreen_Incoming_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Incoming_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Outgoing_Button")]
    public class Tests_AccountsSettingsScreen_Outgoing_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Outgoing_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "IMAP_Button")]
    public class Tests_AccountsSettingsScreen_IMAP_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_IMAP_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.IMAP_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Add_Email_Account_Button")]
    public class Tests_AccountsSettingsScreen_Add_Email_Account_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Add_Email_Account_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Add_Email_Account_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Remove_Account_Button")]
    public class Tests_AccountsSettingsScreen_Remove_Account_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Remove_Account_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Remove_Account_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Import_Accounts_Button")]
    public class Tests_AccountsSettingsScreen_Import_Accounts_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Import_Accounts_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Import_Accounts_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Check_Order_Up_Button")]
    public class Tests_AccountsSettingsScreen_Check_Order_Up_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Check_Order_Up_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Check_Order_Up_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings", "Check_Order_Down_Button")]
    public class Tests_AccountsSettingsScreen_Check_Order_Down_Button : Button_Verification
    {
        public Tests_AccountsSettingsScreen_Check_Order_Down_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Check_Order_Down_Button)
        { }
    }
}