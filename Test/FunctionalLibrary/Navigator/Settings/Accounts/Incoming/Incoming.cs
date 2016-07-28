using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts.Incoming
{
    public class Incoming : NavigatorBase, IIncoming
    {
        public Incoming()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.Incoming_Button.Click();
        }
    }
}