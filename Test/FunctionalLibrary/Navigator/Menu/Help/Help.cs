using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Menu.Help
{
    public class Help : NavigatorBase, IHelp
    {
        public Help()
        {
            MailWasher.UiMap.MainWindow.Menu.Help_Button.Click();
        }
    }
}