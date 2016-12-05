using System.Reflection;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar
{
    public class EventLogToolBarScreenWhite : AppScreen, IEventLogToolBarScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public EventLogToolBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649
        private TestStack.White.UIItems.Button BtnClearEntry;
        private TestStack.White.UIItems.Button BtnResetLog;
#pragma warning restore 0649

        public UiMapItems.Button.IButton Clear_Entry_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnClearEntry, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        public UiMapItems.Button.IButton Reset_Log_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnResetLog, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }
    }
}