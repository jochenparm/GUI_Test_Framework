using Test.UiMaps.MainWindow.Tabs.RecycleBin.SearchBar;
using Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.Factory
{
    internal class RecycleBinFactoryWhite : IRecycleBinFactory
    {
        private readonly ScreenRepository screenRepository;

        public RecycleBinFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        ToolBar.IRecycleBinToolBarScreen IRecycleBinFactory.PopulateRecycleBinToolBarScreen()
        {
            return this.screenRepository.Get<RecycleBinToolBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        SearchBar.IRecycleBinSearchBarScreen IRecycleBinFactory.PopulateRecycleBinSearchBarScreen()
        {
            return this.screenRepository.Get<RecycleBinSearchBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}