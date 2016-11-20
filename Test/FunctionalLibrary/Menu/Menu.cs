using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.File;
using Test.FunctionalLibrary.Menu.View;

namespace Test.FunctionalLibrary.Menu
{
    public class Menu : IMenu
    {
        public Menu()
        {
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