namespace Test.UiMaps.MainWindow.Tabs.Settings.Sync
{
    public interface ISyncSettingsScreen
    {
        UiMapItems.Button.IButton Account_Button { get; }
        UiMapItems.Button.IButton Mobile_Button { get; }
    }
}