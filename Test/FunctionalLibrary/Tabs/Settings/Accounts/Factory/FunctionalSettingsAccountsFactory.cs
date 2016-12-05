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
    internal class FunctionalSettingsAccountsFactory : IFunctionalSettingsAccountsFactory
    {
        private ISettingsAccountsGeneral Get_General()
        {
            return new General.SettingsAccountsGeneral();
        }

        ISettingsAccountsGeneral IFunctionalSettingsAccountsFactory.Get_General()
        {
            return this.Get_General();
        }

        private ISettingsAccountsIncoming Get_Incoming()
        {
            return new Incoming.SettingsAccountsIncoming();
        }

        ISettingsAccountsIncoming IFunctionalSettingsAccountsFactory.Get_Incoming()
        {
            return this.Get_Incoming();
        }

        private ISettingsAccountsOutgoing Get_Outgoing()
        {
            return new Outgoing.SettingsAccountsOutgoing();
        }

        ISettingsAccountsOutgoing IFunctionalSettingsAccountsFactory.Get_Outgoing()
        {
            return this.Get_Outgoing();
        }
    }
}