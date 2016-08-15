using Test.UiMaps.MainWindow.Menu.Email;
using Test.UiMaps.MainWindow.Menu.File;
using Test.UiMaps.MainWindow.Menu.Help;
using Test.UiMaps.MainWindow.Menu.View;
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

        public IFileMenuScreen PopulateFileMenuScreen()
        {
            return this.screenRepository.Get<FileMenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        public IEmailMenuScreen PopulateEmailMenuScreen()
        {
            return this.screenRepository.Get<EmailMenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        public IHelpMenuScreen PopulateHelpMenuScreen()
        {
            return this.screenRepository.Get<HelpMenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        public IViewMenuScreen PopulateViewMenuScreen()
        {
            return this.screenRepository.Get<ViewMenuScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}