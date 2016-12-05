using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.General;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.IMAP;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts
{
    public interface IAccountsNavigator : INavigatorBase
    {
        IGeneralNavigator General { get; }
        IIMAPNavigator IMAP { get; }
        IIncomingNavigator Incoming { get; }
        IOutgoingNavigator Outgoing { get; }
    }
}