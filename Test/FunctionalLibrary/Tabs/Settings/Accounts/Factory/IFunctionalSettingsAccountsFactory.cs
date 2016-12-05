using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.General;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Tabs.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.Factory
{
    internal interface IFunctionalSettingsAccountsFactory
    {
        ISettingsAccountsGeneral Get_General();

        ISettingsAccountsIncoming Get_Incoming();

        ISettingsAccountsOutgoing Get_Outgoing();
    }
}