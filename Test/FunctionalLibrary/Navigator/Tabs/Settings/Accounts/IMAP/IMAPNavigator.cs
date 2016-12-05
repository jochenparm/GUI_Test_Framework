using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.IMAP
{
    public class IMAPNavigator : NavigatorBase, IIMAPNavigator
    {
        public IMAPNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts.IMAP_Button.Click();
        }
    }
}