﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow;

namespace Test.UiMaps
{
    public interface IUiMap
    {
        IMainWindowScreen MainWindow { get; }
    }
}