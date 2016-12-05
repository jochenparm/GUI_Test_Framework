using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.Email;
using Test.FunctionalLibrary.Menu.Factory;
using Test.FunctionalLibrary.Menu.File;
using Test.FunctionalLibrary.Menu.Help;
using Test.FunctionalLibrary.Menu.View;

namespace Test.FunctionalLibrary.Menu
{
    public class Menu : IMenu
    {
        private readonly IFunctionalMenuFactory _menuFactory;

        public Menu()
        {
            this._menuFactory = new FunctionalMenuFactory();
        }

        IEmail IMenu.Email
        {
            get
            {
                return this._menuFactory.Get_Email();
            }
        }

        File.IFile IMenu.File
        {
            get
            {
                return this._menuFactory.Get_File();
            }
        }

        IHelp IMenu.Help
        {
            get
            {
                return this._menuFactory.Get_Help();
            }
        }

        IView IMenu.View
        {
            get
            {
                return this._menuFactory.Get_View();
            }
        }
    }
}