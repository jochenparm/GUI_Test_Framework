using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar
{
    public class EventLogToolBarScreenWhite : AppScreen, IEventLogToolBarScreen
    {
        public EventLogToolBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649
        private TestStack.White.UIItems.Button BtnClearEntry;
        private TestStack.White.UIItems.Button BtnResetLog;
#pragma warning restore 0649

        public UiMapItems.Button.IButton Clear_Entry_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnClearEntry);
            }
        }

        public UiMapItems.Button.IButton Reset_Log_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnResetLog);
            }
        }
    }
}