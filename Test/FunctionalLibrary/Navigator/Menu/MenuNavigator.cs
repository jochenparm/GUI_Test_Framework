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
    public class MenuNavigator : IMenuNavigator
    {
        public MenuNavigator()
        {
        }

        private IEmailNavigator Email
        {
            get
            {
                return new Email.EmailNavigator();
            }
        }

        IEmailNavigator IMenuNavigator.Email
        {
            get
            {
                return this.Email;
            }
        }

        private IFileNavigator File
        {
            get
            {
                return new File.FileNavigator();
            }
        }

        IFileNavigator IMenuNavigator.File
        {
            get
            {
                return this.File;
            }
        }

        private IHelpNavigator Help
        {
            get
            {
                return new Help.HelpNavigator();
            }
        }

        IHelpNavigator IMenuNavigator.Help
        {
            get
            {
                return this.Help;
            }
        }

        private IViewNavigator View
        {
            get
            {
                return new View.ViewNavigator();
            }
        }

        IViewNavigator IMenuNavigator.View
        {
            get
            {
                return this.View;
            }
        }
    }
}