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
    public class Menu : IMenu
    {
        public Menu()
        {
        }

        private IEmail Email
        {
            get
            {
                return new Email.Email();
            }
        }

        IEmail IMenu.Email
        {
            get
            {
                return this.Email;
            }
        }

        private IFile File
        {
            get
            {
                return new File.File();
            }
        }

        IFile IMenu.File
        {
            get
            {
                return this.File;
            }
        }

        private IHelp Help
        {
            get
            {
                return new Help.Help();
            }
        }

        IHelp IMenu.Help
        {
            get
            {
                return this.Help;
            }
        }

        private IView View
        {
            get
            {
                return new View.View();
            }
        }

        IView IMenu.View
        {
            get
            {
                return this.View;
            }
        }
    }
}