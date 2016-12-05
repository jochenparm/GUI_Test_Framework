using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Application
{
    public class ApplicationNavigator : NavigatorBase, IApplicationNavigator
    {
        public ApplicationNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Application_Button.Click();
        }
    }
}