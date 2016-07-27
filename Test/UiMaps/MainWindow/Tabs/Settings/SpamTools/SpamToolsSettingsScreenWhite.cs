using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.SpamTools
{
    public class SpamToolsSettingsScreenWhite : AppScreen, ISpamToolsSettingsScreen
    {
        public SpamToolsSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }
    }
}