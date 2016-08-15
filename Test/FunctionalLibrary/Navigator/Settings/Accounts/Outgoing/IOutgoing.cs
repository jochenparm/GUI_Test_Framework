﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Settings.Accounts.Outgoing.Advanced;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.Outgoing
{
    public interface IOutgoing : INavigatorBase
    {
        IAdvanced Advanced { get; }
    }
}