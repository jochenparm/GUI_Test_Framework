using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar.Factory
{
    internal class RecycleBinToolBarFactoryWhite : IRecycleBinToolBarFactory
    {
        private readonly ScreenRepository screenRepository;

        public RecycleBinToolBarFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        IRecycleBinToolBarScreen IRecycleBinToolBarFactory.PopulateRecycleBinToolBarScreen()
        {
            return this.screenRepository.Get<RecycleBinToolBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}