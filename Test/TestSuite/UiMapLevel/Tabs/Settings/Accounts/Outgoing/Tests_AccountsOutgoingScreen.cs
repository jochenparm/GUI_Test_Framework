using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.Outgoing
{
    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing", "Save_Button")]
    public class Tests_AccountsOutgoingScreen_Save_Button : Button_Verification
    {
        public Tests_AccountsOutgoingScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing", "Advanced_Button")]
    public class Tests_AccountsOutgoingScreen_Advanced_Button : Button_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Advanced_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing", "SMTP_Server_Address_TextBox")]
    public class Tests_AccountsOutgoingScreen_SMTP_Server_Address_TextBox : TextBox_Verification
    {
        public Tests_AccountsOutgoingScreen_SMTP_Server_Address_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Address_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Server_Port_Number_TextBox")]
    public class Tests_AccountsOutgoingScreen_Advanced_Server_Port_Number_TextBox : TextBox_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Server_Port_Number_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Server_Port_Number_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Username_TextBox")]
    public class Tests_AccountsOutgoingScreen_Advanced_Username_TextBox : TextBox_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Username_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Username_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Password_TextBox")]
    public class Tests_AccountsOutgoingScreen_Advanced_Password_TextBox : TextBox_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Password_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Password_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "SMTP_Server_Requires_Authentication_CheckBox")]
    public class Tests_AccountsOutgoingScreen_Advanced_SMTP_Server_Requires_Authentication_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_SMTP_Server_Requires_Authentication_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.SMTP_Server_Requires_Authentication_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Restore_Default_Button")]
    public class Tests_AccountsOutgoingScreen_Advanced_Restore_Default_Button : Button_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Restore_Default_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Restore_Default_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Secure_Connection_DropDownMenu")]
    public class Tests_AccountsOutgoingScreen_Advanced_Secure_Connection_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Secure_Connection_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Secure_Connection_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton")]
    public class Tests_AccountsOutgoingScreen_Advanced_Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton : RadioButton_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_Same_Settings_As_My_Incoming_Mail_Server_RadioButton)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Outgoing_Advanced", "Use_The_Following_Login_RadioButton")]
    public class Tests_AccountsOutgoingScreen_Advanced_Use_The_Following_Login_RadioButton : RadioButton_Verification
    {
        public Tests_AccountsOutgoingScreen_Advanced_Use_The_Following_Login_RadioButton()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Use_The_Following_Login_RadioButton)
        { }
    }
}