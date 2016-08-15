using Test.UiMaps.MainWindow.Menu.Email;
using Test.UiMaps.MainWindow.Menu.File;
using Test.UiMaps.MainWindow.Menu.Help;
using Test.UiMaps.MainWindow.Menu.View;

namespace Test.UiMaps.MainWindow.Menu
{
    public interface IMenuScreen
    {
        IFileMenuScreen File { get; }
        IEmailMenuScreen Email { get; }
        IHelpMenuScreen Help { get; }
        IViewMenuScreen View { get; }

        UiMapItems.Button.IButton File_Button { get; }
        UiMapItems.Button.IButton Email_Button { get; }
        UiMapItems.Button.IButton Help_Button { get; }
        UiMapItems.Button.IButton View_Button { get; }
    }
}