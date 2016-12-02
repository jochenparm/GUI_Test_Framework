using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General;

namespace Test.FunctionalLibrary.Tabs.Settings
{
    public interface ISettings
    {
        IAccounts Accounts { get; }
        IGeneral General { get; }
    }
}