using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.EventLog;
using Test.FunctionalLibrary.Navigator.Tabs.Inbox;
using Test.FunctionalLibrary.Navigator.Tabs.RecycleBin;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;

namespace Test.FunctionalLibrary.Navigator.Tabs
{
    public interface ITabsNavigator
    {
        IInboxNavigator Inbox { get; }
        IRecycleBinNavigator RecycleBin { get; }
        ISettingsNavigator Settings { get; }
        IEventLogNavigator EventLog { get; }
    }
}