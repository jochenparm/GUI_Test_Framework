﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.File;
using Test.FunctionalLibrary.Menu.View;

namespace Test.FunctionalLibrary.Menu
{
    public interface IMenu
    {
        IFile File { get; }
        IView View { get; }
    }
}