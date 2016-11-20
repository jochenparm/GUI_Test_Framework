using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync.Account
{
    public class Account : NavigatorBase, IAccount
    {
        public Account()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Sync.Account_Button.Click();
        }
    }
}