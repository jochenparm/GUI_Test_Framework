using Test.UiMaps.MainWindow.Tabs.Settings.Display.Alerts;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.EventLog;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.General;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.Inbox;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.RecycleBin;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Display
{
    public interface IDisplaySettingsScreen
    {
        IDisplayAlertsScreen Display { get; }
        IDisplayEventLogScreen EventLog { get; }
        IDisplayGeneralScreen General { get; }
        IDisplayInboxScreen Inbox { get; }
        IDisplayRecycleBinScreen RecycleBin { get; }
    }
}