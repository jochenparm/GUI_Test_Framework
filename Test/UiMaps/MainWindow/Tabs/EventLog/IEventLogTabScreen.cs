using Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar;

namespace Test.UiMaps.MainWindow.Tabs.EventLog
{
    public interface IEventLogTabScreen
    {
        IEventLogToolBarScreen ToolBar { get; }
    }
}