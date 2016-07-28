using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.Outgoing
{
    public class Outgoing : NavigatorBase, IOutgoing
    {
        public Outgoing()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing_Button.Click();
        }
    }
}