using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Outgoing;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Factory
{
    internal class AccountsSettingsFactoryWhite : IAccountsSettingsFactory
    {
        private readonly ScreenRepository screenRepository;

        public AccountsSettingsFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        General.IAccountsGeneralScreen IAccountsSettingsFactory.PopulateAccountsGeneralScreen()
        {
            return this.screenRepository.Get<AccountsGeneralScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        IMAP.IAccountsIMAPScreen IAccountsSettingsFactory.PopulateAccountsIMAPScreen()
        {
            return this.screenRepository.Get<AccountsIMAPScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Incoming.IAccountsIncomingScreen IAccountsSettingsFactory.PopulateAccountsIncomingScreen()
        {
            return this.screenRepository.Get<AccountsIncomingScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Outgoing.IAccountsOutgoingScreen IAccountsSettingsFactory.PopulateAccountsOutgoingScreen()
        {
            return this.screenRepository.Get<AccountsOutgoingScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}