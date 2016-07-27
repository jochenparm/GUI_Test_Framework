using Test.UiMaps.MainWindow;

namespace Test.UiMaps.ScreenFactory
{
    internal interface IScreenFactory
    {
        IMainWindowScreen PopulateMainWindowScreen();
    }
}