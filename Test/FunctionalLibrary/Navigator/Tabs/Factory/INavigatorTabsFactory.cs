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
    internal interface INavigatorTabsFactory
    {
        IEventLogNavigator Get_EventLog();

        IInboxNavigator Get_Inbox();

        IRecycleBinNavigator Get_RecycleBin();

        ISettingsNavigator Get_Settings();
    }
}