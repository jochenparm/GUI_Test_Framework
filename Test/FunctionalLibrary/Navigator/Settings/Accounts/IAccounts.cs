using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.General;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.IMAP;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts
{
    public interface IAccounts : INavigatorBase
    {
        IGeneral General { get; }
        IIMAP IMAP { get; }
        IIncoming Incoming { get; }
        IOutgoing Outgoing { get; }
    }
}