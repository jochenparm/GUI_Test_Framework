using Test.UiMaps.MainWindow.Tabs.Settings.Accounts;
using Test.UiMaps.MainWindow.Tabs.Settings.Display;
using Test.UiMaps.MainWindow.Tabs.Settings.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools;
using Test.UiMaps.MainWindow.Tabs.Settings.Sync;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Factory
{
    internal class SettingsTabFactoryWhite : ISettingsTabFactory
    {
        private readonly ScreenRepository screenRepository;

        public SettingsTabFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        Accounts.IAccountsSettingsScreen ISettingsTabFactory.PopulateAccountSettingsScreen()
        {
            return this.screenRepository.Get<AccountsSettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        General.IGeneralSettingsScreen ISettingsTabFactory.PopulateGeneralSettingsScreen()
        {
            return this.screenRepository.Get<GeneralSettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        SpamTools.ISpamToolsSettingsScreen ISettingsTabFactory.PopulateSpamToolsSettingsScreen()
        {
            return this.screenRepository.Get<SpamToolsSettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Display.IDisplaySettingsScreen ISettingsTabFactory.PopulateDisplaySettingsScreen()
        {
            return this.screenRepository.Get<DisplaySettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        RecycleBin.IRecycleBinSettingsScreen ISettingsTabFactory.PopulateRecycleBinSettingsScreen()
        {
            return this.screenRepository.Get<RecycleBinSettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Sync.ISyncSettingsScreen ISettingsTabFactory.PopulateSyncSettingsScreen()
        {
            return this.screenRepository.Get<SyncSettingsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}