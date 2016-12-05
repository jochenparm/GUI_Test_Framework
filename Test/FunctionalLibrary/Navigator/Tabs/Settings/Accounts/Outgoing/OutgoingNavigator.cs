using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Outgoing
{
    public class OutgoingNavigator : NavigatorBase, IOutgoingNavigator
    {
        public OutgoingNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing_Button.Click();
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