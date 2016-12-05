using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Menu.View
{
    public class ViewNavigator : NavigatorBase, IViewNavigator
    {
        public ViewNavigator()
        {
            MailWasher.UiMap.MainWindow.Menu.View_Button.Click();
        }
    }
}