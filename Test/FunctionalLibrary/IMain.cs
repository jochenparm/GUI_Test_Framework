using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;

namespace Test.FunctionalLibrary
{
    public interface IMain
    {
        IMain Maximize_Window();

        IMain Minimize_Window();

        IMain Close_Window();

        INavigator Navigator { get; }
    }
}