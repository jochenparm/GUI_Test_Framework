using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.EventLog;
using Test.FunctionalLibrary.Navigator.Tabs.Inbox;
using Test.FunctionalLibrary.Navigator.Tabs.RecycleBin;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;

namespace Test.FunctionalLibrary.Navigator.Tabs.Factory
{
    internal class NavigatorTabsFactory : INavigatorTabsFactory
    {
        private IEventLogNavigator Get_EventLog()
        {
            return new EventLog.EventLogNavigator();
        }

        IEventLogNavigator INavigatorTabsFactory.Get_EventLog()
        {
            return this.Get_EventLog();
        }

        private IInboxNavigator Get_Inbox()
        {
            return new Inbox.InboxNavigator();
        }

        IInboxNavigator INavigatorTabsFactory.Get_Inbox()
        {
            return this.Get_Inbox();
        }

        private IRecycleBinNavigator Get_RecycleBin()
        {
            return new RecycleBin.RecycleBinNavigator();
        }

        IRecycleBinNavigator INavigatorTabsFactory.Get_RecycleBin()
        {
            return this.Get_RecycleBin();
        }

        private ISettingsNavigator Get_Settings()
        {
            return new Settings.SettingsNavigator();
        }

        ISettingsNavigator INavigatorTabsFactory.Get_Settings()
        {
            return this.Get_Settings();
        }
    }
}