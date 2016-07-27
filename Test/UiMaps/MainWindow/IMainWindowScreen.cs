namespace Test.UiMaps.MainWindow
{
    public interface IMainWindowScreen
    {
        UiMaps.MainWindow.StatusBar.IStatusBarScreen StatusBar { get; }
        UiMaps.MainWindow.Tabs.ITabsScreen Tabs { get; }
        UiMaps.MainWindow.Menu.IMenuScreen Menu { get; }

        UiMapItems.Button.IButton InboxTab_Button { get; }
        UiMapItems.Button.IButton RecycleBinTab_Button { get; }
        UiMapItems.Button.IButton SettingsTab_Button { get; }
        UiMapItems.Button.IButton EventLogTab_Button { get; }

        UiMapItems.Button.IButton MinimizeWindow_Button { get; }

        UiMapItems.Button.IButton MaximizeWindow_Button { get; }
        UiMapItems.Button.IButton CloseWindow_Button { get; }
    }
}