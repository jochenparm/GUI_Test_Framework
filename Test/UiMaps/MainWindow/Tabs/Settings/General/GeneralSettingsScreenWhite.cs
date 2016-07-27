using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General
{
    public class GeneralSettingsScreenWhite : AppScreen, IGeneralSettingsScreen
    {
        public GeneralSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }
    }
}