using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;
using Test.UiMaps;

namespace Test.TestSuite.UiMapLevel.Settings.Accounts.IMAP
{
    [TestFixture, Property("UiMap_Accounts_Settings_IMAP", "Refresh_Button")]
    public class Tests_AccountsGeneralScreen_Refresh_Button : Button_Verification
    {
        public Tests_AccountsGeneralScreen_Refresh_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.IMAP.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.IMAP.Refresh_Button)
        { }
    }

    [TestFixture, Property("UiMap_Accounts_Settings_IMAP", "Save_Button")]
    public class Tests_AccountsGeneralScreen_Save_Button : Button_Verification
    {
        public Tests_AccountsGeneralScreen_Save_Button()
            : base(() => MailWasher.Navigator.Tabs.Settings.Accounts.IMAP.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.IMAP.Save_Button)
        { }
    }
}