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
    public interface ITabs
    {
        IInbox Inbox { get; }
        IRecycleBin RecycleBin { get; }
        ISettings Settings { get; }
        IEventLog EventLog { get; }
    }
}