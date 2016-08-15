using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.Incoming.Advanced;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.Incoming
{
    public interface IIncoming : INavigatorBase
    {
        IAdvanced Advanced { get; }
    }
}