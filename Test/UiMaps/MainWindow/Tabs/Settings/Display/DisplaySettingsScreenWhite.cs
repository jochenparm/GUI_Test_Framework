using System;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.Alerts;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.EventLog;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.General;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.Inbox;
using Test.UiMaps.MainWindow.Tabs.Settings.Display.RecycleBin;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Display
{
    public class DisplaySettingsScreenWhite : AppScreen, IDisplaySettingsScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public DisplaySettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

        IDisplayAlertsScreen IDisplaySettingsScreen.Display
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDisplayEventLogScreen IDisplaySettingsScreen.EventLog
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDisplayGeneralScreen IDisplaySettingsScreen.General
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDisplayInboxScreen IDisplaySettingsScreen.Inbox
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDisplayRecycleBinScreen IDisplaySettingsScreen.RecycleBin
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}