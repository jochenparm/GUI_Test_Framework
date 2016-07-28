using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.Accounts;
using Test.FunctionalLibrary.Navigator.Settings.Sync;

namespace Test.FunctionalLibrary.Navigator.Settings
{
    public interface ISettings : INavigatorBase
    {
        IAccounts Accounts { get; }
        ISync Sync { get; }
    }
}