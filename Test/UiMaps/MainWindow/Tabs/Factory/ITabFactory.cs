using Test.UiMaps.MainWindow.Tabs.EventLog;
using Test.UiMaps.MainWindow.Tabs.Inbox;
using Test.UiMaps.MainWindow.Tabs.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings;

namespace Test.UiMaps.MainWindow.Tabs.Factory
{
    internal interface ITabFactory
    {
        IInboxTabScreen PopulateInboxTabScreen();

        IRecycleBinTabScreen PopulateRecycleBinTabScreen();

        ISettingsTabScreen PopulateSettingsTabScreen();

        IEventLogTabScreen PopulateEventLogTabScreen();
    }
}