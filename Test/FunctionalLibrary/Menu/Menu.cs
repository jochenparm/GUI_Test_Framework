using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.Email;
using Test.FunctionalLibrary.Menu.File;
using Test.FunctionalLibrary.Menu.Help;
using Test.FunctionalLibrary.Menu.View;

namespace Test.FunctionalLibrary.Menu
{
    public class Menu : IMenu
    {
        public Menu()
        {
        }

        private Email.IEmail Email
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

        private File.IFile File
        {
            get
            {
                return new File.File();
            }
        }

        File.IFile IMenu.File
        {
            get
            {
                return this.File;
            }
        }

        private Help.IHelp Help
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