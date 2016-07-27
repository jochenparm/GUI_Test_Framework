using Test.UiMaps.MainWindow.Tabs.Settings.Accounts;
using Test.UiMaps.MainWindow.Tabs.Settings.Display;
using Test.UiMaps.MainWindow.Tabs.Settings.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools;
using Test.UiMaps.MainWindow.Tabs.Settings.Sync;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Factory
{
    internal interface ISettingsTabFactory
    {
        IAccountsSettingsScreen PopulateAccountSettingsScreen();

        IGeneralSettingsScreen PopulateGeneralSettingsScreen();

        ISpamToolsSettingsScreen PopulateSpamToolsSettingsScreen();

        IDisplaySettingsScreen PopulateDisplaySettingsScreen();

        IRecycleBinSettingsScreen PopulateRecycleBinSettingsScreen();

        ISyncSettingsScreen PopulateSyncSettingsScreen();
    }
}