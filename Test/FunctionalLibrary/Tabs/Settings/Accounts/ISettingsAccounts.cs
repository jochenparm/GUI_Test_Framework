using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.General;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts
{
    public interface ISettingsAccounts
    {
        ISettingsAccounts Add_Email_Account(string accountName, string accountEmailAddress);

        ISettingsAccounts Remove_Email_Account(string accountName);

        bool Exists(string accountName);

        ISettingsAccountsGeneral General { get; }
        ISettingsAccountsIncoming Incoming { get; }
        ISettingsAccountsOutgoing Outgoing { get; }
    }
}