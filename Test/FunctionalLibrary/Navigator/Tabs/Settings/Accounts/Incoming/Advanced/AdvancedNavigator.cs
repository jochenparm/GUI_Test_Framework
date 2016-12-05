using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Incoming.Advanced
{
    public class AdvancedNavigator : NavigatorBase, IAdvancedNavigator
    {
        public AdvancedNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming.Advanced_Button.Click();
        }
    }
}