using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.EventLog;
using Test.FunctionalLibrary.Navigator.Tabs.Factory;
using Test.FunctionalLibrary.Navigator.Tabs.Inbox;
using Test.FunctionalLibrary.Navigator.Tabs.RecycleBin;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;

namespace Test.FunctionalLibrary.Navigator.Tabs
{
    public class TabNavigator : ITabsNavigator
    {
        private readonly INavigatorTabsFactory _navigatorTabsFactory;

        public TabNavigator()
        {
            this._navigatorTabsFactory = new NavigatorTabsFactory();
        }

        IEventLogNavigator ITabsNavigator.EventLog
        {
            get
            {
                return this._navigatorTabsFactory.Get_EventLog();
            }
        }

        IInboxNavigator ITabsNavigator.Inbox
        {
            get
            {
                return this._navigatorTabsFactory.Get_Inbox();
            }
        }

        IRecycleBinNavigator ITabsNavigator.RecycleBin
        {
            get
            {
                return this._navigatorTabsFactory.Get_RecycleBin();
            }
        }

        ISettingsNavigator ITabsNavigator.Settings
        {
            get
            {
                return this._navigatorTabsFactory.Get_Settings();
            }
        }
    }
}