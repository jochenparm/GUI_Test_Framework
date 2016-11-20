using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings
{
    public interface ISettings : INavigatorBase
    {
        IAccounts Accounts { get; }
        ISync Sync { get; }
        IGeneral General { get; }
        IRecycleBin RecycleBin { get; }
    }
}