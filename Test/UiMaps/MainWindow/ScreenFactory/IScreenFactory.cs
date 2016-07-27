using Test.UiMaps.MainWindow.Menu;
using Test.UiMaps.MainWindow.StatusBar;
using Test.UiMaps.MainWindow.Tabs;

namespace Test.UiMaps.MainWindow.ScreenFactory
{
    internal interface IScreenFactory
    {
        IStatusBarScreen PopulateStatusBarScreen();

        ITabsScreen PopulateTabsScreen();

        IMenuScreen PopulateMenuScreen();
    }
}