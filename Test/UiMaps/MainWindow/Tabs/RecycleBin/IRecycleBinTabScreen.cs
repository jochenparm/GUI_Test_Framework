namespace Test.UiMaps.MainWindow.Tabs.RecycleBin
{
    public interface IRecycleBinTabScreen
    {
        UiMaps.MainWindow.Tabs.RecycleBin.ToolBar.IRecycleBinToolBarScreen ToolBar { get; }
        UiMaps.MainWindow.Tabs.RecycleBin.SearchBar.IRecycleBinSearchBarScreen SearchBar { get; }
    }
}