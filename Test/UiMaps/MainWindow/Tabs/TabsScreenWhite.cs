using Test.UiMaps.MainWindow.Tabs.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs
{
    public class TabsScreenWhite : AppScreen, ITabsScreen
    {
        private readonly ITabFactory _tabFactory;

        public TabsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._tabFactory = new TabFactoryWhite(screenRepository);
        }

        Inbox.IInboxTabScreen ITabsScreen.Inbox
        {
            get
            {
                return this._tabFactory.PopulateInboxTabScreen();
            }
        }

        RecycleBin.IRecycleBinTabScreen ITabsScreen.RecycleBin
        {
            get
            {
                return this._tabFactory.PopulateRecycleBinTabScreen();
            }
        }

        Settings.ISettingsTabScreen ITabsScreen.Settings
        {
            get
            {
                return this._tabFactory.PopulateSettingsTabScreen();
            }
        }

        EventLog.IEventLogTabScreen ITabsScreen.EventLog
        {
            get
            {
                return this._tabFactory.PopulateEventLogTabScreen();
            }
        }
    }
}