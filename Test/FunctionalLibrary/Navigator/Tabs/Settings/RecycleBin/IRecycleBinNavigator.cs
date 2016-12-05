using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin.General;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin.Restoring;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin
{
    public interface IRecycleBinNavigator : INavigatorBase
    {
        IGeneralNavigator General { get; }
        IRestoringNavigator Restoring { get; }
    }
}