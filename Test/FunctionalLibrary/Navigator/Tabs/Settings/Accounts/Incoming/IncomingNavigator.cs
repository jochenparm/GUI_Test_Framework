using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Incoming
{
    public class IncomingNavigator : NavigatorBase, IIncomingNavigator
    {
        public IncomingNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming_Button.Click();
        }

        public Advanced.IAdvancedNavigator Advanced
        {
            get
            {
                return new Advanced.AdvancedNavigator();
            }
        }
    }
}