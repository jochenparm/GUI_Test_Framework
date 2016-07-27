using Test.UiMaps.MainWindow.Menu.File;

namespace Test.UiMaps.MainWindow.Menu.Factory
{
    internal interface IMenuFactory
    {
        IFileMenuScreen PopulateFileMenuScreen();
    }
}