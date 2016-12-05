using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.Email;
using Test.FunctionalLibrary.Menu.File;
using Test.FunctionalLibrary.Menu.Help;
using Test.FunctionalLibrary.Menu.View;

namespace Test.FunctionalLibrary.Menu.Factory
{
    internal interface IFunctionalMenuFactory
    {
        IEmail Get_Email();

        IFile Get_File();

        IHelp Get_Help();

        IView Get_View();
    }
}