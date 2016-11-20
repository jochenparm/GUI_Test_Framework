using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Menu.Email;
using Test.FunctionalLibrary.Navigator.Menu.File;
using Test.FunctionalLibrary.Navigator.Menu.Help;
using Test.FunctionalLibrary.Navigator.Menu.View;

namespace Test.FunctionalLibrary.Navigator.Menu
{
    public interface IMenu
    {
        IEmail Email { get; }
        IFile File { get; }
        IHelp Help { get; }
        IView View { get; }
    }
}