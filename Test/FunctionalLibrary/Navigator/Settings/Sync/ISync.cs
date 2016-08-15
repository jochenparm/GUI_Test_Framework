using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.Sync.Account;
using Test.FunctionalLibrary.Navigator.Settings.Sync.Mobile;

namespace Test.FunctionalLibrary.Navigator.Settings.Sync
{
    public interface ISync : INavigatorBase
    {
        IAccount Account { get; }
        IMobile Mobile { get; }
    }
}