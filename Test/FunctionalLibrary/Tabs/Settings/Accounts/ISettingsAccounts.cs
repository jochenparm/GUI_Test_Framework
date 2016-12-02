using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.General;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts
{
    public interface ISettingsAccounts
    {
        void Add_Email_Account(string accountName, string accountEmailAddress);

        void Remove_Email_Account(string accountName);

        ISettingsAccountsGeneral General { get; }
    }
}