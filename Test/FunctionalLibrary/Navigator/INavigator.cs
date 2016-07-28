using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.EventLog;
using Test.FunctionalLibrary.Navigator.Inbox;
using Test.FunctionalLibrary.Navigator.RecycleBin;
using Test.FunctionalLibrary.Navigator.Settings;

namespace Test.FunctionalLibrary.Navigator
{
    public interface INavigator
    {
        IInbox Inbox { get; }
        IRecycleBin RecycleBin { get; }
        ISettings Settings { get; }
        IEventLog EventLog { get; }
    }
}