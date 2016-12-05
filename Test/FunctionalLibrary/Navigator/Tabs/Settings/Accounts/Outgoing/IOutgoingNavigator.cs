using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Outgoing.Advanced;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Outgoing
{
    public interface IOutgoingNavigator : INavigatorBase
    {
        IAdvancedNavigator Advanced { get; }
    }
}