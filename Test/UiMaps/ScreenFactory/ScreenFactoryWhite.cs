using Test.UiMaps.MainWindow;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.ScreenFactory
{
    internal class ScreenFactoryWhite : IScreenFactory
    {
        private readonly ScreenRepository screenRepository;

        public ScreenFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        MainWindow.IMainWindowScreen IScreenFactory.PopulateMainWindowScreen()
        {
            return this.screenRepository.Get<MainWindowScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}