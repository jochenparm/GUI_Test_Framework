namespace Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar
{
    public interface IEventLogToolBarScreen
    {
        UiMaps.UiMapItems.Button.IButton Clear_Entry_Button { get; }
        UiMaps.UiMapItems.Button.IButton Reset_Log_Button { get; }
    }
}