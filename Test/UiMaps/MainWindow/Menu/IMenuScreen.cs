using Test.UiMaps.MainWindow.Menu.File;

namespace Test.UiMaps.MainWindow.Menu
{
    public interface IMenuScreen
    {
        IFileMenuScreen File { get; }

        UiMapItems.Button.IButton File_Button { get; }
    }
}