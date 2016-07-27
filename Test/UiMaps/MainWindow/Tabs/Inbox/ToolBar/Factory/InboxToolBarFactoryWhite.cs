using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar.Factory
{
    internal class InboxToolBarFactoryWhite : IInboxToolBarFactory
    {
        private readonly ScreenRepository screenRepository;

        public InboxToolBarFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        IInboxToolBarScreen IInboxToolBarFactory.PopulateInboxToolBarScreen()
        {
            return this.screenRepository.Get<InboxToolBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}