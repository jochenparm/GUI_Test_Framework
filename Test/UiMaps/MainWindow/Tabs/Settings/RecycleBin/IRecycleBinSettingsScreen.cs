using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Restoring;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin
{
    public interface IRecycleBinSettingsScreen
    {
        UiMapItems.Button.IButton General_Button { get; }
        UiMapItems.Button.IButton Restoring_Button { get; }
        IRecycleBinGeneralScreen General { get; }
        IRecycleBinRestoringScreen Restoring { get; }
    }
}