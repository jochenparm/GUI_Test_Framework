using Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar;
using Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.EventLog
{
    public class EventLogTabScreenWhite : AppScreen, IEventLogTabScreen
    {
        private readonly IEventLogToolBarFactory _toolBarFactory;

        public EventLogTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._toolBarFactory = new EventLogToolBarFactoryWhite(screenRepository);
        }

        public IEventLogToolBarScreen ToolBar
        {
            get
            {
                return this._toolBarFactory.PopulateEventLogToolBarScreen();
            }
        }
    }
}