using Test.UiMaps.MainWindow.Menu.Email;
using Test.UiMaps.MainWindow.Menu.File;
using Test.UiMaps.MainWindow.Menu.Help;
using Test.UiMaps.MainWindow.Menu.View;

namespace Test.UiMaps.MainWindow.Menu.Factory
{
    internal interface IMenuFactory
    {
        IFileMenuScreen PopulateFileMenuScreen();

        IEmailMenuScreen PopulateEmailMenuScreen();

        IHelpMenuScreen PopulateHelpMenuScreen();

        IViewMenuScreen PopulateViewMenuScreen();
    }
}