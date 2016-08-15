using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.Outgoing.Advanced
{
    public class Advanced : NavigatorBase, IAdvanced
    {
        public Advanced()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Outgoing.Advanced_Button.Click();
        }
    }
}