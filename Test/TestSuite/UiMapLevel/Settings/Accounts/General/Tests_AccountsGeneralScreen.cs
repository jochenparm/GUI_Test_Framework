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
using Test.UiMaps.UiMapItems.CheckBox;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.General
{
    [TestFixture, Property("UiMap_Accounts_Settings_General", "Save_Button")]
    public class Tests_AccountsGeneralScreen_Save_Button : Button_Verification
    {
        public Tests_AccountsGeneralScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Save_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_General", "Include_In_Default_Mail_Check_CheckBox")]
    public class Tests_AccountsGeneralScreen_IncludeInDefaultMailCheck_CheckBox : CheckBox_Verification
    {
        public Tests_AccountsGeneralScreen_IncludeInDefaultMailCheck_CheckBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Include_In_Default_Mail_Check_CheckBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_General", "Account_Description_TextBox")]
    public class Tests_AccountsGeneralScreen_AccountDescription_TextBox : TextBox_Verification
    {
        public Tests_AccountsGeneralScreen_AccountDescription_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Account_Description_TextBox)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_General", "Email_Address_TextBox")]
    public class Tests_AccountsGeneralScreen_EmailAddress_TextBox : TextBox_Verification
    {
        public Tests_AccountsGeneralScreen_EmailAddress_TextBox()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.General.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.General.Email_Address_TextBox)
        { }
    }
}