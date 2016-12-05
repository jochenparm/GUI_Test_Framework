using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync.Account;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync.Mobile;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync
{
    public interface ISyncNavigator : INavigatorBase
    {
        IAccountNavigator Account { get; }
        IMobileNavigator Mobile { get; }
    }
}