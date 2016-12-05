using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Updates
{
    public class UpdatesNavigator : NavigatorBase, IUpdatesNavigator
    {
        public UpdatesNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Updates_Button.Click();
        }
    }
}