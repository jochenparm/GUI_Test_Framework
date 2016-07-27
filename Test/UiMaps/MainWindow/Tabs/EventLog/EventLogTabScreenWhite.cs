using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.EventLog
{
    public class EventLogTabScreenWhite : AppScreen, IEventLogTabScreen
    {
        public EventLogTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }
    }
}