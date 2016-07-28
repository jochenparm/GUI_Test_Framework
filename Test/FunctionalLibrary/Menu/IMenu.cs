using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.File;

namespace Test.FunctionalLibrary.Menu
{
    public interface IMenu
    {
        IFile File { get; }
    }
}