using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Menu;
using Test.FunctionalLibrary.Navigator.Tabs;

namespace Test.FunctionalLibrary.Navigator
{
    public interface INavigator
    {
        ITabsNavigator Tabs { get; }
        IMenuNavigator Menu { get; }
    }
}