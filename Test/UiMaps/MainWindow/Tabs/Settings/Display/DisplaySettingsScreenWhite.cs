using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Display
{
    public class DisplaySettingsScreenWhite : AppScreen, IDisplaySettingsScreen
    {
        public DisplaySettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }
    }
}