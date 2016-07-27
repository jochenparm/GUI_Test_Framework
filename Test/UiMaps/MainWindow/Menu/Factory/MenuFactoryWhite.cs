using Test.UiMaps.MainWindow.Menu.File;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Menu.Factory
{
    internal class MenuFactoryWhite : IMenuFactory
    {
        private readonly ScreenRepository screenRepository;

        public MenuFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        File.IFileMenuScreen IMenuFactory.PopulateFileMenuScreen()
        {
            return this.screenRepository.Get<FileMenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}