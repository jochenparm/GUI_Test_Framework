using Test.UiMaps.MainWindow.Menu;
using Test.UiMaps.MainWindow.StatusBar;
using Test.UiMaps.MainWindow.Tabs;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.ScreenFactory
{
    internal class ScreenFactoryWhite : IScreenFactory
    {
        private readonly ScreenRepository screenRepository;

        public ScreenFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        StatusBar.IStatusBarScreen IScreenFactory.PopulateStatusBarScreen()
        {
            return this.screenRepository.Get<StatusBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Tabs.ITabsScreen IScreenFactory.PopulateTabsScreen()
        {
            return this.screenRepository.Get<TabsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Menu.IMenuScreen IScreenFactory.PopulateMenuScreen()
        {
            return this.screenRepository.Get<MenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}