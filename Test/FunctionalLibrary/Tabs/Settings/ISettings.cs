using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.Accounts;
using Test.FunctionalLibrary.Tabs.Settings.General;

namespace Test.FunctionalLibrary.Tabs.Settings
{
    public interface ISettings
    {
        ISettingsAccounts Accounts { get; }
        ISettingsGeneral General { get; }
    }
}