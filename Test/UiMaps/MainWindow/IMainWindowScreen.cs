namespace Test.UiMaps.MainWindow
{
    public interface IMainWindowScreen
    {
        UiMaps.MainWindow.StatusBar.IStatusBarScreen StatusBar { get; }
        UiMaps.MainWindow.Tabs.ITabsScreen Tabs { get; }
        UiMaps.MainWindow.Menu.IMenuScreen Menu { get; }

        UiMapItems.Tab.ITab Inbox_Tab { get; }
        UiMapItems.Tab.ITab RecycleBin_Tab { get; }
        UiMapItems.Tab.ITab Settings_Tab { get; }
        UiMapItems.Tab.ITab EventLog_Tab { get; }

        UiMapItems.Button.IButton MinimizeWindow_Button { get; }

        UiMapItems.Button.IButton MaximizeWindow_Button { get; }
        UiMapItems.Button.IButton CloseWindow_Button { get; }
    }
}