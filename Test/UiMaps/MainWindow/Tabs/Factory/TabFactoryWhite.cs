using Test.UiMaps.MainWindow.Tabs.EventLog;
using Test.UiMaps.MainWindow.Tabs.Inbox;
using Test.UiMaps.MainWindow.Tabs.RecycleBin;
using Test.UiMaps.MainWindow.Tabs.Settings;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Factory
{
    internal class TabFactoryWhite : ITabFactory
    {
        private readonly ScreenRepository screenRepository;

        public TabFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        Inbox.IInboxTabScreen ITabFactory.PopulateInboxTabScreen()
        {
            return this.screenRepository.Get<InboxTabScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        RecycleBin.IRecycleBinTabScreen ITabFactory.PopulateRecycleBinTabScreen()
        {
            return this.screenRepository.Get<RecycleBinTabScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Settings.ISettingsTabScreen ITabFactory.PopulateSettingsTabScreen()
        {
            return this.screenRepository.Get<SettingsTabScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        EventLog.IEventLogTabScreen ITabFactory.PopulateEventLogTabScreen()
        {
            return this.screenRepository.Get<EventLogTabScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}