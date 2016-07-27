using Test.UiMaps.MainWindow.Tabs.Settings.Accounts;
using Test.UiMaps.MainWindow.Tabs.Settings.Display;
using Test.UiMaps.MainWindow.Tabs.Settings.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools;
using Test.UiMaps.MainWindow.Tabs.Settings.Sync;

namespace Test.UiMaps.MainWindow.Tabs.Settings
{
    public interface ISettingsTabScreen
    {
        IGeneralSettingsScreen General { get; }
        IRecycleBinSettingsScreen RecycleBin { get; }
        IAccountsSettingsScreen Accounts { get; }
        ISpamToolsSettingsScreen SpamTools { get; }
        ISyncSettingsScreen Sync { get; }
        IDisplaySettingsScreen Display { get; }
        UiMapItems.Button.IButton General_Button { get; }
        UiMapItems.Button.IButton Accounts_Button { get; }
        UiMapItems.Button.IButton SpamTools_Button { get; }
        UiMapItems.Button.IButton Display_Button { get; }
        UiMapItems.Button.IButton RecycleBin_Button { get; }
        UiMapItems.Button.IButton Sync_Button { get; }
    }
}