using Test.UiMaps.MainWindow.Tabs.EventLog;
using Test.UiMaps.MainWindow.Tabs.Inbox;
using Test.UiMaps.MainWindow.Tabs.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings;

namespace Test.UiMaps.MainWindow.Tabs
{
    public interface ITabsScreen
    {
        IInboxTabScreen Inbox { get; }

        IRecycleBinTabScreen RecycleBin { get; }

        ISettingsTabScreen Settings { get; }

        IEventLogTabScreen EventLog { get; }
    }
}