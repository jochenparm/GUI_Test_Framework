using Test.UiMaps.MainWindow.Tabs.RecycleBin.SearchBar;
using Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.Factory
{
    internal interface IRecycleBinFactory
    {
        IRecycleBinToolBarScreen PopulateRecycleBinToolBarScreen();

        IRecycleBinSearchBarScreen PopulateRecycleBinSearchBarScreen();
    }
}