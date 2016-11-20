using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.Incoming
{
    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Advanced_Button")]
    public class Tests_AccountsIncomingScreen_Advanced_Button : Button_Verification
    {
        public Tests_AccountsIncomingScreen_Advanced_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Advanced_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Save_Button")]
    public class Tests_AccountsIncomingScreen_Save_Button : Button_Verification
    {
        public Tests_AccountsIncomingScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Server_Address_TextBox")]
    public class Tests_AccountsIncomingScreen_Server_Address_TextBox : TextBox_Verification
    {
        public Tests_AccountsIncomingScreen_Server_Address_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Address_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "User_Name_TextBox")]
    public class Tests_AccountsIncomingScreen_User_Name_TextBox : TextBox_Verification
    {
        public Tests_AccountsIncomingScreen_User_Name_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.User_Name_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Password_TextBox")]
    public class Tests_AccountsIncomingScreen_Password_TextBox : TextBox_Verification
    {
        public Tests_AccountsIncomingScreen_Password_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Password_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Server_Port_Number_TextBox")]
    public class Tests_AccountsIncomingScreen_ServerPortNumber_TextBox : TextBox_Verification
    {
        public Tests_AccountsIncomingScreen_ServerPortNumber_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Port_Number_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Remember_Password_CheckBox")]
    public class Tests_AccountsIncomingScreen_RememberPassword_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsIncomingScreen_RememberPassword_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Remember_Password_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Remember_Password_CheckBox")]
    public class Tests_AccountsIncomingScreen_StoreCachedEmails_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsIncomingScreen_StoreCachedEmails_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Store_Cached_Emails_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Use_OAUTH_CheckBox")]
    public class Tests_AccountsIncomingScreen_UseOAUTH_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsIncomingScreen_UseOAUTH_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Use_OAUTH_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Download_Read_Emails_CheckBox")]
    public class Tests_AccountsIncomingScreen_DownloadReadEmails_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsIncomingScreen_DownloadReadEmails_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Download_Read_Emails_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Move_Deleted_Messages_Into_Folder_CheckBox")]
    public class Tests_AccountsIncomingScreen_MoveDeletedMessagesIntoFolder_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsIncomingScreen_MoveDeletedMessagesIntoFolder_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Move_Deleted_Messages_Into_Folder_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Destination_Folder_DropDownMenu")]
    public class Tests_AccountsIncomingScreen_DestinationFolder_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_AccountsIncomingScreen_DestinationFolder_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Destination_Folder_DropDownMenu)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_Incoming", "Server_Type_DropDownMenu")]
    public class Tests_AccountsIncomingScreen_ServerType_DropDownMenu : DropDownMenu_Verification
    {
        public Tests_AccountsIncomingScreen_ServerType_DropDownMenu()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.Incoming.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Server_Type_DropDownMenu)
        { }
    }
}