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
    internal class FunctionalMenuFactory : IFunctionalMenuFactory
    {
        private IEmail Get_Email()
        {
            return new Email.Email();
        }

        IEmail IFunctionalMenuFactory.Get_Email()
        {
            return this.Get_Email();
        }

        private IFile Get_File()
        {
            return new File.File();
        }

        IFile IFunctionalMenuFactory.Get_File()
        {
            return this.Get_File();
        }

        private IHelp Get_Help()
        {
            return new Help.Help();
        }

        IHelp IFunctionalMenuFactory.Get_Help()
        {
            return this.Get_Help();
        }

        private IView Get_View()
        {
            return new View.View();
        }

        IView IFunctionalMenuFactory.Get_View()
        {
            return this.Get_View();
        }
    }
}