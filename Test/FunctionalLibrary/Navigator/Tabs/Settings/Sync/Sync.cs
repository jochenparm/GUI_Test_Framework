using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Sync
{
    public class Sync : NavigatorBase, ISync
    {
        public Sync()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Sync_Button.Click();
        }

        public Account.IAccount Account
        {
            get
            {
                return new Account.Account();
            }
        }

        public Mobile.IMobile Mobile
        {
            get
            {
                return new Mobile.Mobile();
            }
        }
    }
}