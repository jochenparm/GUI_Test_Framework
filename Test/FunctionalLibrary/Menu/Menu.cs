using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Menu.File;

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
    }
}