using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin
{
    public class RecycleBinSettingsScreenWhite : AppScreen, IRecycleBinSettingsScreen
    {
        public RecycleBinSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }
    }
}