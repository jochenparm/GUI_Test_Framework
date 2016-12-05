using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Menu.File
{
    public class FileNavigator : NavigatorBase, IFileNavigator
    {
        public FileNavigator()
        {
            MailWasher.UiMap.MainWindow.Menu.File_Button.Click();
        }
    }
}