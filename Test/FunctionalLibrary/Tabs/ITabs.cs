using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;
using Test.FunctionalLibrary.Tabs.Inbox;

namespace Test.FunctionalLibrary.Tabs
{
    public interface ITabs
    {
        IInbox Inbox { get; }

        ISettings Settings { get; }
    }
}